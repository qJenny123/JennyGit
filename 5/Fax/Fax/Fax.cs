using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fax
{
    public class Fax
    {
        public bool SendFax(string phone, string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                return false;
            }
            if (string.IsNullOrEmpty(phone))
            {
                return false;
            }
            if (phone.Length != 12)   //判断电话号码的长度是否为12
            {
                return false;
            }
            if (phone[0] - '0' < 0 || phone[0] - '0' > 9) 
            {
                return false;
            }
            if (phone[3] != '-' || phone[7] != '-')
            {
                return false;
            }
            if (phone[1] - '0' < 0 || phone[1] - '0' > 9 ||
                phone[2] - '0' < 0 || phone[2] - '0' > 9 ||
                phone[4] - '0' < 0 || phone[4] - '0' > 9 ||
                phone[5] - '0' < 0 || phone[5] - '0' > 9 ||
                phone[6] - '0' < 0 || phone[6] - '0' > 9 ||
                phone[8] - '0' < 0 || phone[8] - '0' > 9 ||
                phone[9] - '0' < 0 || phone[9] - '0' > 9 ||
                phone[10] - '0' < 0 || phone[10] - '0' > 9 ||
                phone[11] - '0' < 0 || phone[11] - '0' > 9
                )
            {
                return false;
            }
            //phone:xnn-nnn-nnnn
            if (phone[1] == '1' && phone[2] == '1')
            {
                return false;
            }
            if (phone[1] == '9')
            {
                return false;
            }
            if (phone[0] == '3' && phone[1] == '7')
            {
                return false;
            }
            if (phone[0] == '9' && phone[1] == '6')
            {
                return false;
            }
            return true;

        }
    }
}
