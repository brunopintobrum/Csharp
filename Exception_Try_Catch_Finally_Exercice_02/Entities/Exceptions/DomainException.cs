using System;

namespace Exception_Try_Catch_Finally_Exercice_02.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
