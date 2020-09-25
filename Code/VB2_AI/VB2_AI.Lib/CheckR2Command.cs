using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VB2_AI.Lib
{
    class CheckR2Command : IRuleCheckCommand
    {
        private readonly char[] _content;
        private readonly int _type;

        public CheckR2Command(char[] content, int type)
        {
            this._content = content;
            this._type = type;
        }
        public bool Check()
        {
            switch (_type)
            {
                case 1:
                    {
                        //var dis_p1 = 0;
                        var dip_p1 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[0])).DIP;

                        var dis_p2 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[1])).DIS;
                        //var dip_p2 = 0;

                        var dis_c = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[2])).DIS;
                        var dip_c = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[2])).DIP;

                        return dis_p2 >= dis_c && dip_p1 >= dip_c;
                    }
                case 2:
                    {
                        //var dis_p1 = 0;
                        var dis_p2 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[1])).DIS;                        
                        
                        var dip_p1 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[0])).DIS;
                        //var dip_p2 = 0;
                        
                        var dis_c = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[2])).DIS;
                        var dip_c = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[2])).DIP;
                        
                        return dis_p2 >= dis_c && dip_p1 >= dip_c;
                    }
                case 3:
                    {
                        //var dis_p1 = 0;
                        var dip_p1 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[0])).DIP;

                        var dis_p2 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[1])).DIP;
                        //var dip_p2 = 0;

                        var dis_c = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[2])).DIS;
                        var dip_c = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[2])).DIP;
                        return dis_p2 >= dis_c && dip_p1 >= dip_c;
                    }
                case 4:
                    {
                        //var dis_p1 = 0;
                        var dip_p1 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[0])).DIS;

                        var dis_p2 = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[1])).DIP;
                        //var dip_p2 = 0;

                        var dis_c = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[2])).DIS;
                        var dip_c = Syllogism.Quantifiers.FirstOrDefault(x => x.Symbol.Equals(_content[2])).DIP;
                        return dis_p2 >= dis_c && dip_p1 >= dip_c;
                    }
                default:
                    return false;
            }
        }
    }
}
