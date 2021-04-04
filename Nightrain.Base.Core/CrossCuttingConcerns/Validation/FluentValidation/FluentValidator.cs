using System;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;

namespace Nightrain.Base.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class FluentValidator
    {
        public static void Validate(Type validator, object entity)
        {
            var fluentValidator = (IValidator)Activator.CreateInstance(validator);
            var context = new ValidationContext<object>(entity);
            if (fluentValidator == null) return;
            var result = fluentValidator.Validate(context);
            if (result.Errors.Count > 0) throw new ValidationException(result.Errors);
        }

    }
}
