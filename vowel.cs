using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glasnye
{
    internal class Vowel
    {
        Dictionary<char, int> vowelCounts = new Dictionary<char, int>
            {
                { 'а', 0 },
                { 'е', 0 },
                { 'ё', 0 },
                { 'и', 0 },
                { 'о', 0 },
                { 'э', 0 },
                { 'ю', 0 },
                { 'я', 0 },
                { 'ы', 0 },
                { 'у', 0 }
            };
        public Vowel(string text)
        {
            Jopa(text);
        }
        
        void Jopa(string text)
        {
            foreach (char c in text)
            {
                if (vowelCounts.ContainsKey(c))
                    vowelCounts[c]++;
            }
            string message = "Количество гласных в тексте:\n";
            foreach (var vowel in vowelCounts)
            {
                if (vowel.Value > 0)
                    message += $"{vowel.Key}: {vowel.Value}\n";
            }
            MessageBox.Show(message);
        }
    }
}
