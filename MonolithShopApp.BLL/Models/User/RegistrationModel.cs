﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace EdProject.BLL
{
    public class RegistrationModel: IValidatableObject
    {
        public string Username { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {   
            List<ValidationResult> errors = new List<ValidationResult>();

            if (!Username.Any(char.IsLetterOrDigit) || string.IsNullOrWhiteSpace(Username))
            {
                errors.Add(new ValidationResult(ErrorConstant.INVALID_FIELD_USERNAME));
            }
            if (FirstName.Any(char.IsDigit) || FirstName.Any(char.IsPunctuation) || FirstName.Any(char.IsSymbol) || string.IsNullOrWhiteSpace(FirstName))
            {
                errors.Add(new ValidationResult("Invalid FirstName"));
            }
            if (LastName.Any(char.IsDigit) || LastName.Any(char.IsPunctuation) || LastName.Any(char.IsSymbol) || string.IsNullOrWhiteSpace(LastName))
            {
                errors.Add(new ValidationResult("Invalid LastName"));
            }
            if (!Regex.IsMatch(Password, VariableConstant.PASSWORD_PATTERN))
            {
                errors.Add(new ValidationResult(ErrorConstant.INCORRECT_PASSWORD));
            }
            if (!Regex.IsMatch(Email, VariableConstant.EMAIL_PATERN, RegexOptions.IgnoreCase))
            {
                errors.Add(new ValidationResult(ErrorConstant.INCORRECT_EMAIL));
            }
            if (!Password.Equals(ConfirmPassword))
            {
                errors.Add(new ValidationResult("Password's doesn't match"));
            }

            if (Username.Length < VariableConstant.MIN_FIELD_SIZE)
            {
                errors.Add(new ValidationResult($"{ErrorConstant.INVALID_FIELD_USERNAME}. {ErrorConstant.FIELD_IS_TOO_SHORT}"));
            }
            if(FirstName.Length < VariableConstant.MIN_FIELD_SIZE)
            {
                errors.Add(new ValidationResult($"{ErrorConstant.INVALID_FIELD_FIRSTNAME}. {ErrorConstant.FIELD_IS_TOO_SHORT}"));
            }
            if (LastName.Length < VariableConstant.MIN_FIELD_SIZE)
            {
                errors.Add(new ValidationResult($"{ErrorConstant.INVALID_FIELD_LASTNAME}. {ErrorConstant.FIELD_IS_TOO_SHORT}"));
            }

            if (!errors.Any())
            {
                return errors;
            }
            throw new CustomException(string.Join(", ", errors), HttpStatusCode.BadRequest);
        }
    }
}
