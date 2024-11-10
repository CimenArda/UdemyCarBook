using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands;

namespace UdemyCarBook.Application.Validators.ReviewValidators
{
	public class CreateReviewValidator :AbstractValidator<CreateReviewCommand>
	{
        public CreateReviewValidator()
        {
            RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("İsim En az 5 karakter olmalıdır");
            RuleFor(x => x.CustomerName).MaximumLength(5).WithMessage("İsim En fazla 25 karakter olmalıdır");
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("İsim Kısmı Boş Geçilemez ");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum Kısmı Boş Geçilemez ");
			RuleFor(x => x.Comment).MinimumLength(30).WithMessage("İsim En az 30 karakter olmalıdır");

		}
	}
}
