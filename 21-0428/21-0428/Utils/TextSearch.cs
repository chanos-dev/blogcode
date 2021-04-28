using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _21_0428.Utils
{
    class TextSearch
    {
        char[] chr = { 'ㄱ', 'ㄲ', 'ㄴ', 'ㄷ', 'ㄸ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅃ', 'ㅅ', 'ㅆ', 'ㅇ', 'ㅈ', 'ㅉ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ' };
        string[] str = { "가", "까", "나", "다", "따", "라", "마", "바", "빠", "사", "싸", "아", "자", "짜", "차", "카", "타", "파", "하" }; 
        int[] chrint = { 44032, 44620, 45208, 45796, 46384, 46972, 47560, 48148, 48736, 49324, 49912, 50500, 51088, 51676, 52264, 52852, 53440, 54028, 54616, 55204 }; 

        public List<string> SearchWord(List<string> contents, string word, out string searchPattern)
        { 
            string pattern = "";

            for (int i = 0; i < word.Length; i++)
            { 
                if (word[i] >= 'ㄱ' && word[i] <= 'ㅎ')
                {
                    for (int j = 0; j < chr.Length; j++)
                    {
                        if (word[i] == chr[j])
                        {
                            pattern += string.Format("[{0}-{1}]", str[j], (char)(chrint[j + 1] - 1));
                        }
                    }
                } 
                else if (word[i] >= '가')
                {
                    int magic = ((word[i] - '가') % 588);

                    magic = 27 - (magic % 28);

                    pattern += $"[{word[i]}-{(char)(word[i] + magic)}]"; 
                }  
                else if (word[i] >= 'A' && word[i] <= 'z')
                { 
                    bool isLower = word[i] >= 'a' ? true : false; 

                    pattern += $"[{word[i]}{(char)(isLower ? word[i] - 32 : word[i] + 32)}]";
                } 
                else if (word[i] >= '0' && word[i] <= '9')
                {
                    pattern += word[i];
                }
            }

            searchPattern = pattern;
            return contents.Where(e => Regex.IsMatch(e.ToString(), pattern)).ToList();
        }
    }
}
