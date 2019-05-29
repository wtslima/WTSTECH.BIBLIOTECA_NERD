using FluentValidation.Results;
using System;


namespace WTSTECH.BIBLIOTECANERD.DOMINIO.SHARED
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }

    }
}
