﻿namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// Assembler class to convert a Developer entity into a GreetDeveloperResponse.
/// Handles transformation of domain entities into REST response objects.
/// </summary>
public static class GreetDeveloperAssembler
{
    /// <summary>
    /// Converts a Developer entity into a GreetDeveloperResponse.
    /// Returns an anonymous greeting if the developer is null or has empty names,
    /// otherwise returns a personalized greeting with ID and full name.
    /// </summary>
    /// <param name="developer">The developer entity to convert, may be null.</param>
    /// <returns>A GreetDeveloperResponse with appropriate greeting details.</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? developer)
    {
        if (developer == null || developer.IsAnyNameEmpty())
        {
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        }
        return new GreetDeveloperResponse(developer.Id, developer.GetFullName(), 
            $"Congrats {developer.GetFullName()}! You are an ASP.NET Developer");
    }
}