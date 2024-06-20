using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Variant_6
{

    public class Task3
    {
        public class Reverter
        {
            public string Input { get; }
            public string Output { get; }

            public Reverter(string text)
            {
                Input = text;
                Output = ReverseWords(text);
            }

            private string ReverseWords(string text)
            {
                if (string.IsNullOrEmpty(text))
                {
                    return "";
                }

                string[] words = text.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = new string(words[i].Reverse().ToArray());
                }
                return string.Join(" ", words);
            }

            public override string ToString()
            {
                return Output;
            }
        }

        
    }
}
