using System;
<<<<<<< HEAD
using System.Linq;
using Nightrain.Base.Core.CrossCuttingConcerns.Validation.FluentValidation;
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
>>>>>>> 10be876906c4d0feadf4fc0a5acc95dead24cc9c
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace Nightrain.Base.Core.Aspects.PostSharp.Validation
{
    [PSerializable]
    public class ValidationAspect : OnMethodBoundaryAspect
    {

        public Type Validator;

        public override void OnEntry(MethodExecutionArgs args)
        {
<<<<<<< HEAD
            if (Validator?.BaseType is null) return;
            var entityType = Validator.BaseType.GetGenericArguments()[0];
            var entity = args.Arguments.FirstOrDefault(t => t.GetType() == entityType);
            FluentValidator.Validate(Validator, entity);
=======
            var validator = (IValidator)Activator.CreateInstance(Validator);
            if (validator is null || Validator?.BaseType is null) return;
            var entityType = Validator.BaseType.GetGenericArguments()[0];
            var entity = args.Arguments.FirstOrDefault(t => t.GetType() == entityType);
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (result.Errors.Count > 0) throw new ValidationException(result.Errors);
>>>>>>> 10be876906c4d0feadf4fc0a5acc95dead24cc9c
        }

    }
}
