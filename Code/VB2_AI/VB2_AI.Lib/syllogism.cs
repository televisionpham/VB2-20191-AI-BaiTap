using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB2_AI.Lib
{
    public class Syllogism
    {             
        private Dictionary<int, IRuleCheckCommand> _commands = new Dictionary<int, IRuleCheckCommand>();
        public static List<Quantifier> Quantifiers = new List<Quantifier>
        {
            new Quantifier
            {
                Symbol = 'A',
                DIS = 5,
                DIP = 1,
                Quality = true
            },
            new Quantifier
            {
                Symbol = 'E',
                DIS = 5,
                DIP = 5,
                Quality = false
            },
            new Quantifier
            {
                Symbol = 'P',
                DIS = 4,
                DIP = 1,
                Quality = true
            },
            new Quantifier
            {
                Symbol = 'B',
                DIS = 4,
                DIP = 5,
                Quality = false
            },
            new Quantifier
            {
                Symbol = 'T',
                DIS = 3,
                DIP = 1,
                Quality = true
            },
            new Quantifier
            {
                Symbol = 'D',
                DIS = 3,
                DIP = 5,
                Quality = false
            },
            new Quantifier
            {
                Symbol = 'K',
                DIS = 2,
                DIP = 1,
                Quality = true
            },
            new Quantifier
            {
                Symbol = 'G',
                DIS = 2,
                DIP = 5,
                Quality = false
            },
            new Quantifier
            {
                Symbol = 'I',
                DIS = 1,
                DIP = 1,
                Quality = true
            },
            new Quantifier
            {
                Symbol = 'O',
                DIS = 1,
                DIP = 5,
                Quality = false
            },
        };
        public Syllogism(char[] content, int type)        {
            if (content.Length != 3)
            {
                throw new Exception("Phải có 3 ký tự");
            }
            if (type < 1 || type > 4)
            {
                throw new Exception("Loại phải từ 1 đến 4");
            }            
            this.Content = content;
            this.Type = type;
            Pattern = $"{new string(content).ToUpper()}-{type}";
            _commands.Add(1, new CheckR1Command(Content, type));
            _commands.Add(2, new CheckR2Command(Content, type));
            _commands.Add(3, new CheckR3Command(Content));
            _commands.Add(4, new CheckR4Command(Content));
            for (int i = 0; i < 4; i++)
            {
                Rules[i] = _commands[i + 1].Check();
                if (!Rules[i])
                {
                    IsValid = false;
                }
            }

        }

        public char[] Content { get; private set; }
        public int Type { get; private set; }
        public bool[] Rules { get; } = new bool[4];
        public bool IsValid { get; private set; } = true;
        public string Pattern { get; private set; }

        public override string ToString()
        {
            return $"{Pattern} {string.Join(" ", Rules)}";
        }

        public static string GenerateSentence(char q, string s, string p)
        {            
            switch (q)
            {
                case 'A':
                    return $"Tất cả {s} là {p}";
                case 'E':
                    return $"Không có {s} là {p}";
                case 'P':
                    return $"Gần như tất cả {s} là {p}";
                case 'B':
                    return $"Gần như tất cả {s} không là {p}";
                case 'T':
                    return $"Hầu hết {s} là {p}";
                case 'D':
                    return $"Hầu hết {s} không là {p}";
                case 'K':
                    return $"Nhiều {s} là {p}";
                case 'G':
                    return $"Nhiều {s} không là {p}";
                case 'I':
                    return $"Một số {s} là {p}";
                case 'O':
                    return $"Một số {s} không là {p}";
                default:
                    return string.Empty;
            }
        }

        public static string GenerateSyllogism(int type, char[] q, string s, string p, string m)
        {
            var sb = new StringBuilder();
            switch (type)
            {
                case 1:
                    {
                        sb.AppendLine(GenerateSentence(q[0], m, p));
                        sb.AppendLine(GenerateSentence(q[1], s, m));
                        sb.AppendLine(GenerateSentence(q[2], s, p));
                        break;
                    }
                case 2:
                    {
                        sb.AppendLine(GenerateSentence(q[0], p, m));
                        sb.AppendLine(GenerateSentence(q[1], s, m));
                        sb.AppendLine(GenerateSentence(q[2], s, p));
                        break;
                    }
                case 3:
                    {
                        sb.AppendLine(GenerateSentence(q[0], m, p));
                        sb.AppendLine(GenerateSentence(q[1], m, s));
                        sb.AppendLine(GenerateSentence(q[2], s, p));
                        break;
                    }
                case 4:
                    {
                        sb.AppendLine(GenerateSentence(q[0], p, m));
                        sb.AppendLine(GenerateSentence(q[1], m, s));
                        sb.AppendLine(GenerateSentence(q[2], s, p));
                        break;
                    }
                default:
                    return string.Empty;
            }
            return sb.ToString();
        }
    }
}
