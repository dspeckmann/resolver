using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.Resolver.DNS
{
    class Packet
    {
        public Header Header { get; set; }
        public List<Question> QuestionSection { get; set; }
        public List<ResourceRecord> AnswerSection { get; set; }
        public List<ResourceRecord> AuthoritySection { get; set; }
        public List<ResourceRecord> AdditionalSection { get; set; }
        
        public Packet()
        {
            Header = new Header();
            QuestionSection = new List<Question>();
            AnswerSection = new List<ResourceRecord>();
            AuthoritySection = new List<ResourceRecord>();
            AdditionalSection = new List<ResourceRecord>();
        }

        public Packet(byte[] source)
        {
            // TODO: Read packet
        }

        public byte[] GetBytes()
        {
            var bytes = new List<Byte>();
            var message = new MessagePart[] { Header }
                .Concat(QuestionSection)
                .Concat(AnswerSection)
                .Concat(AuthoritySection)
                .Concat(AdditionalSection);

            foreach(MessagePart messagePart in message)
            {
                bytes.AddRange(messagePart.GetBytes());
            }

            return bytes.ToArray();
        }
    }
}
