# Swedbank Pay SDK for .NET

![Swedbank Pay SDK for .NET][opengraph-image]

## Build status

| Build server | Platform | Status                                    |
| ------------ | -------- | ----------------------------------------- |
| Azure DevOps | Windows  | [![Build Status][azdo-badge]][azdo-build] |

## About

**IMPORTANT**: This SDK is at an early stage and not yet used in production. We do not offer support for this version, but will release supported versions in the future. Feel free to play around, but for full functionality and support, please wait for the supported, stable release.

`SwedbankPay.Sdk` is a `netstandard2` library that allows you to interact with Swedbank Pay's API Platform in a statically typed client.

## Supported APIs

* **Payment Order**
  * create payment order
  * get payment order
  * capture
  * cancel
  * reversal
  * abort
* **Swish Payments**
  * create swish payment
  * get swish payment
  * abort
  * reversal
* **Card Payments**
  * create card payment
  * get card payment
  * capture
  * cancel
  * reversal

# Sample apps

Check the [the samples folder][samples].  
To run the sample site. Make sure to add your PayeeId and ApiBaseUrl from SwedbankPay in appsettings.json

You will also need to add the token from SwedbankPay in secrets.json by running the following command in the project root folder.  
`dotnet user-secrets set "Token" "{Your token}" --project src/Samples/Sample.AspNetCore`


## Getting started

Install the `SwedbankPay.Sdk` NuGet in your project:

```
dotnet add package SwedbankPay.Sdk
```

To configure the SDK in one line using `Microsoft.Extensions.DependencyInjection`,
you need to install `SwedbankPay.Sdk.Extensions`. The SDK can then be configured
as such:
(This requires that you have added `SwedbankPay.Sdk.Extensions`)

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddSwedbankPayClient(ApiUrl, AuthenticationToken);
    ...
}
```

This will add the `ISwedbankPayClient` to the system, as well as interfaces for
all api's in case you want to have more control over what is injected.
See the [samples][samples] for inspiration and usage.
Using this to configure the `SwedbankPay.Sdk` will set up a
`LoggingDelegatingHandler` that aids in logging error responses from the api.


  [azdo-badge]: https://dev.azure.com/SwedbankPay/swedbank-pay-sdk-dotnet/_apis/build/status/swedbank-pay-sdk-dotnet-CI?branchName=master
  [azdo-build]: https://dev.azure.com/SwedbankPay/swedbank-pay-sdk-dotnet/_build/latest?definitionId=1&branchName=master
  [samples]: https://github.com/SwedbankPay/swedbank-pay-sdk-dotnet/tree/master/src/Samples
  [opengraph-image]: https://repository-images.githubusercontent.com/211096861/84938580-53e8-11ea-8062-53a4f9ad981c
