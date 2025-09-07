﻿namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// A record representing a request to greet a developer.
/// Contains the developer's first and last names, used as input for POST requests.
/// </summary>
/// <param name="FirstName">The developer's first name, may be null.</param>
/// <param name="LastName">The developer's last name, may be null.</param>
public record GreetDeveloperRequest(string? FirstName, string? LastName);