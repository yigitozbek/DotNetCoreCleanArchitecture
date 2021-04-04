using System;
using System.Linq;
using Nightrain.Base.Core.CrossCuttingConcerns.Validation.FluentValidation;
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
            if (Validator?.BaseType is null) return;
            var entityType = Validator.BaseType.GetGenericArguments()[0];
            var entity = args.Arguments.FirstOrDefault(t => t.GetType() == entityType);
            FluentValidator.Validate(Validator, entity);
        }

    }
}
