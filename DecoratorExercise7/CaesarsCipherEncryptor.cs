using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExercise7
{
    class CaesarsCipherEncryptor : TextMessage
    {
        public CaesarsCipherEncryptor(TextMessage msg, int key)
        {
            // From This is CS 50. Harvard College Fall 2009 problem set 2
            // Caesar's Cipher
            // If p is some plaintext (i.e., an unencrypted message), pi is the i th character in p,
            // and k is a key (i.e., a non-negative integer), then each letter, ci, in the ciphertext, c, is computed
            // as:
            // ci = (pi + k) % 26

            msg.Message = msg.Message.ToUpper();
            this.Message = "";
            for (int i = 0; i < msg.Message.Length; i++)
            {
                int nextChar = msg.Message[i] - 'A';
                nextChar = (nextChar + key) % 26;
                this.Message += (char)(nextChar + 'A');
            }
        }

        public override string ToString()
        {
            return this.Message;
        }
    }
}
