//--------------------------------------------------------------------------------------------------------------
public static void RequestValidations(
    
    string userID, int systemID, HalfDayRequestDto request, UnitOfWork unitOfWork
    )
{
    HalfDayRequestValidation.ValidateUser(userID, systemID, unitOfWork);

}


