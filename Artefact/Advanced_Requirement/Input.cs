using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS2024 {
    public class Input {
        /// <summary>
        /// Removes all characters which is equal to character except the first one.
        /// </summary>
        /// <param name="character"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveAllBarOneOfCharacter(char character, string input) {
            string[] inputSplit = input.Split('.');

            if (inputSplit.Length > 1) {
                string temp = $"{inputSplit[0]}.{inputSplit[1]}";
                for (int i = 2; i < inputSplit.Length; i++) {
                    temp = $"{temp}{inputSplit[i]}";
                }
                return temp;
            }
            return input;
        }
    }
}
