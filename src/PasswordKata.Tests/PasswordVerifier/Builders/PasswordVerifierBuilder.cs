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
}

