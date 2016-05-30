using System;

namespace PasswordKata.Tests
{
    public sealed class PasswordVerifierBuilder : IBuilder
    {
        private PasswordVerifier _passwordVerifier;
        private string _password;

        public PasswordVerifierBuilder()
        {

        }
        public PasswordVerifier Build()
        {
            _passwordVerifier = new PasswordVerifier(_password);
            return _passwordVerifier;

        }
        public PasswordVerifierBuilder WithPassword(string password)
        {
            this._password = password;
            return this;
        }

        public static implicit operator PasswordVerifier(PasswordVerifierBuilder builder)
        {
            return builder.Build();

        }

    }
    public sealed class PasswordVerifierBuilder_Feature_2 : IBuilder
    {
        private PasswordVerifier _passwordVerifier;
        private string _password;

        public PasswordVerifierBuilder_Feature_2()
        {

        }
        public PasswordVerifier Build()
        {
            _passwordVerifier = new PasswordVerifier(_password);
            _passwordVerifier.Ensure_lowercase = false;
            _passwordVerifier.Ensure_Number = false;
            return _passwordVerifier;

        }
        public PasswordVerifierBuilder_Feature_2 WithPassword(string password)
        {
            this._password = password;
            return this;
        }

        public static implicit operator PasswordVerifier(PasswordVerifierBuilder_Feature_2 builder)
        {
            return builder.Build();

        }

    }
}

