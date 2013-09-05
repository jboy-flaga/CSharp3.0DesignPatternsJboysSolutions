using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExercise7
{
    class CaesarsCipherDecryptor : TextMessage
    {
        public CaesarsCipherDecryptor(TextMessage msg, int key)
        {
            msg.Message = msg.Message.ToUpper();
            this.Message = "";
            for (int i = 0; i < msg.Message.Length; i++)
            {
                int nextChar = msg.Message[i] - 'A';
                nextChar = (nextChar - key) % 26;
                this.Message += (char)(nextChar + 'A');
            }
        }

        public override string ToString()
        {
            return this.Message;
        }
    }
}
