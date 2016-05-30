using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordKata.Tests.Mocks
{
    public class PasswordVerifier_Argument_Null_Mock : PasswordVerifier
    {

        public PasswordVerifier_Argument_Null_Mock(string password)
            : base(password)
        {

        }
        new public bool Verify()
        {
            //verify Argument not null only 
            base.Ensure_ArgumentNotNull = true;
            base.Ensure_8Char = false;
            base.Ensure_Uppercase = false;
            base.Ensure_lowercase = false;
            base.Ensure_Number = false;
            return base.Verify();
        }

    }
    public class PasswordVerifier_8_Chars_Mock : PasswordVerifier
    {

        public PasswordVerifier_8_Chars_Mock(string password)
            : base(password)
        {

        }
        new public bool Verify()
        {
            // verify 8 char only
            base.Ensure_ArgumentNotNull = false;
            base.Ensure_8Char = true;
            base.Ensure_Uppercase = false;
            base.Ensure_lowercase = false;
            base.Ensure_Number = false;
            return base.Verify();
        }

    }
    public class PasswordVerifier_Uppercase_Mock : PasswordVerifier
    {

        public PasswordVerifier_Uppercase_Mock(string password)
            : base(password)
        {

        }
        new public bool Verify()
        {
            // verify uppercase only
            base.Ensure_ArgumentNotNull = false;
            base.Ensure_8Char = false;
            base.Ensure_Uppercase = true;
            base.Ensure_lowercase = false;
            base.Ensure_Number = false;
            return base.Verify();
        }

    }
    public class PasswordVerifier_lowercase_Mock : PasswordVerifier
    {

        public PasswordVerifier_lowercase_Mock(string password)
            : base(password)
        {

        }
        new public bool Verify()
        {
            // verify uppercase only
            base.Ensure_ArgumentNotNull = false;
            base.Ensure_8Char = false;
            base.Ensure_Uppercase = false;
            base.Ensure_lowercase = true;
            base.Ensure_Number = false;
            return base.Verify();
        }

    }
    public class PasswordVerifier_Number_Mock : PasswordVerifier
    {

        public PasswordVerifier_Number_Mock(string password)
            : base(password)
        {

        }
        new public bool Verify()
        {
            // verify lowercase only
            base.Ensure_ArgumentNotNull = false;
            base.Ensure_8Char = false;
            base.Ensure_Uppercase = false;
            base.Ensure_lowercase = false;
            base.Ensure_Number = true;
            return base.Verify();
        }

    }
}

