<a name='assembly'></a>

# RSM.HCD.CSharp.Core

## Contents

-   [AccessRule](#T-AndcultureCode-CSharp-Core-Models-Security-AccessRule "RSM.HCD.CSharp.Core.Models.Security.AccessRule")
    -   [#ctor(resource,verb,subject)](#M-AndcultureCode-CSharp-Core-Models-Security-AccessRule-#ctor-System-String,System-String,System-String- "RSM.HCD.CSharp.Core.Models.Security.AccessRule.#ctor(System.String,System.String,System.String)")
    -   [Permission](#P-AndcultureCode-CSharp-Core-Models-Security-AccessRule-Permission "RSM.HCD.CSharp.Core.Models.Security.AccessRule.Permission")
    -   [Resource](#P-AndcultureCode-CSharp-Core-Models-Security-AccessRule-Resource "RSM.HCD.CSharp.Core.Models.Security.AccessRule.Resource")
    -   [Subject](#P-AndcultureCode-CSharp-Core-Models-Security-AccessRule-Subject "RSM.HCD.CSharp.Core.Models.Security.AccessRule.Subject")
    -   [Verb](#P-AndcultureCode-CSharp-Core-Models-Security-AccessRule-Verb "RSM.HCD.CSharp.Core.Models.Security.AccessRule.Verb")
-   [Acl](#T-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl "RSM.HCD.CSharp.Core.Models.Entities.Acls.Acl")
    -   [Permission](#P-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl-Permission "RSM.HCD.CSharp.Core.Models.Entities.Acls.Acl.Permission")
    -   [Resource](#P-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl-Resource "RSM.HCD.CSharp.Core.Models.Entities.Acls.Acl.Resource")
    -   [Subject](#P-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl-Subject "RSM.HCD.CSharp.Core.Models.Entities.Acls.Acl.Subject")
    -   [Verb](#P-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl-Verb "RSM.HCD.CSharp.Core.Models.Entities.Acls.Acl.Verb")
-   [Allow](#T-AndcultureCode-CSharp-Core-Models-Security-Allow "RSM.HCD.CSharp.Core.Models.Security.Allow")
    -   [#ctor(resource,verb,subject)](#M-AndcultureCode-CSharp-Core-Models-Security-Allow-#ctor-System-String,System-String,System-String- "RSM.HCD.CSharp.Core.Models.Security.Allow.#ctor(System.String,System.String,System.String)")
    -   [Permission](#P-AndcultureCode-CSharp-Core-Models-Security-Allow-Permission "RSM.HCD.CSharp.Core.Models.Security.Allow.Permission")
-   [AmazonEBConfigurationProvider](#T-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider")
    -   [#ctor()](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-#ctor "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.#ctor")
    -   [#ctor(stdoutEnabled,configurationFilePath)](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-#ctor-System-Boolean,System-String- "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.#ctor(System.Boolean,System.String)")
    -   [CONFIGURATION_FILE_PATH](#F-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-CONFIGURATION_FILE_PATH "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.CONFIGURATION_FILE_PATH")
    -   [CachedConfiguration](#P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-CachedConfiguration "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.CachedConfiguration")
    -   [ConfigurationFilePath](#P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-ConfigurationFilePath "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.ConfigurationFilePath")
    -   [StdoutEnabled](#P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-StdoutEnabled "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.StdoutEnabled")
    -   [Get(key)](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-Get-System-String- "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.Get(System.String)")
    -   [Has(key)](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-Has-System-String- "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.Has(System.String)")
    -   [Load()](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-Load "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.Load")
    -   [Read()](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-Read "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.Read")
-   [AmazonEBConfigurationSource](#T-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationSource "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationSource")
    -   [Build(builder)](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationSource-Build-Microsoft-Extensions-Configuration-IConfigurationBuilder- "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationSource.Build(Microsoft.Extensions.Configuration.IConfigurationBuilder)")
-   [AndcultureCodeWebHost](#T-AndcultureCode-CSharp-Core-Utilities-Hosting-AndcultureCodeWebHost "RSM.HCD.CSharp.Core.Utilities.Hosting.AndcultureCodeWebHost")
    -   [Preload()](#M-AndcultureCode-CSharp-Core-Utilities-Hosting-AndcultureCodeWebHost-Preload-System-String[]- "RSM.HCD.CSharp.Core.Utilities.Hosting.AndcultureCodeWebHost.Preload(System.String[])")
-   [AndcultureCodeWebHostBuilder](#T-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder "RSM.HCD.CSharp.Core.Models.Hosting.AndcultureCodeWebHostBuilder")
    -   [#ctor()](#M-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder-#ctor "RSM.HCD.CSharp.Core.Models.Hosting.AndcultureCodeWebHostBuilder.#ctor")
    -   [#ctor(args)](#M-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder-#ctor-System-String[]- "RSM.HCD.CSharp.Core.Models.Hosting.AndcultureCodeWebHostBuilder.#ctor(System.String[])")
    -   [Args](#P-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder-Args "RSM.HCD.CSharp.Core.Models.Hosting.AndcultureCodeWebHostBuilder.Args")
    -   [CreateDefaultBuilder()](#M-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder-CreateDefaultBuilder "RSM.HCD.CSharp.Core.Models.Hosting.AndcultureCodeWebHostBuilder.CreateDefaultBuilder")
-   [ApiClaimTypes](#T-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes")
    -   [IS_SUPER_ADMIN](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-IS_SUPER_ADMIN "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.IS_SUPER_ADMIN")
    -   [ROLE_ID](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-ROLE_ID "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.ROLE_ID")
    -   [ROLE_IDS](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-ROLE_IDS "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.ROLE_IDS")
    -   [ROLE_TYPE](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-ROLE_TYPE "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.ROLE_TYPE")
    -   [USER_ID](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-USER_ID "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.USER_ID")
    -   [USER_LOGIN_ID](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-USER_LOGIN_ID "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.USER_LOGIN_ID")
-   [ApplicationConstants](#T-AndcultureCode-CSharp-Core-Constants-ApplicationConstants "RSM.HCD.CSharp.Core.Constants.ApplicationConstants")
    -   [API_DATABASE_CONFIGURATION_KEY](#F-AndcultureCode-CSharp-Core-Constants-ApplicationConstants-API_DATABASE_CONFIGURATION_KEY "RSM.HCD.CSharp.Core.Constants.ApplicationConstants.API_DATABASE_CONFIGURATION_KEY")
-   [Auditable](#T-AndcultureCode-CSharp-Core-Models-Auditable "RSM.HCD.CSharp.Core.Models.Auditable")
    -   [CreatedById](#P-AndcultureCode-CSharp-Core-Models-Auditable-CreatedById "RSM.HCD.CSharp.Core.Models.Auditable.CreatedById")
    -   [CreatedOn](#P-AndcultureCode-CSharp-Core-Models-Auditable-CreatedOn "RSM.HCD.CSharp.Core.Models.Auditable.CreatedOn")
    -   [DeletedById](#P-AndcultureCode-CSharp-Core-Models-Auditable-DeletedById "RSM.HCD.CSharp.Core.Models.Auditable.DeletedById")
    -   [DeletedOn](#P-AndcultureCode-CSharp-Core-Models-Auditable-DeletedOn "RSM.HCD.CSharp.Core.Models.Auditable.DeletedOn")
    -   [UpdatedById](#P-AndcultureCode-CSharp-Core-Models-Auditable-UpdatedById "RSM.HCD.CSharp.Core.Models.Auditable.UpdatedById")
    -   [UpdatedOn](#P-AndcultureCode-CSharp-Core-Models-Auditable-UpdatedOn "RSM.HCD.CSharp.Core.Models.Auditable.UpdatedOn")
-   [BasicAuthenticationConfiguration](#T-AndcultureCode-CSharp-Core-Models-Configuration-BasicAuthenticationConfiguration "RSM.HCD.CSharp.Core.Models.Configuration.BasicAuthenticationConfiguration")
    -   [IsEnabled](#P-AndcultureCode-CSharp-Core-Models-Configuration-BasicAuthenticationConfiguration-IsEnabled "RSM.HCD.CSharp.Core.Models.Configuration.BasicAuthenticationConfiguration.IsEnabled")
    -   [Password](#P-AndcultureCode-CSharp-Core-Models-Configuration-BasicAuthenticationConfiguration-Password "RSM.HCD.CSharp.Core.Models.Configuration.BasicAuthenticationConfiguration.Password")
    -   [UserName](#P-AndcultureCode-CSharp-Core-Models-Configuration-BasicAuthenticationConfiguration-UserName "RSM.HCD.CSharp.Core.Models.Configuration.BasicAuthenticationConfiguration.UserName")
-   [CacheKeys](#T-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys "RSM.HCD.CSharp.Core.Utilities.Caching.CacheKeys")
    -   [DEFAULT_DELIMITER](#F-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-DEFAULT_DELIMITER "RSM.HCD.CSharp.Core.Utilities.Caching.CacheKeys.DEFAULT_DELIMITER")
    -   [GetKey\`\`1(id,includeProperties)](#M-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-GetKey``1-System-Int64,System-Collections-Generic-List{System-Linq-Expressions-Expression{System-Func{``0,System-Object}}}- "RSM.HCD.CSharp.Core.Utilities.Caching.CacheKeys.GetKey``1(System.Int64,System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{``0,System.Object}}})")
    -   [GetKey\`\`1(id,delimiter,includeProperties)](#M-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-GetKey``1-System-Int64,System-String,System-Collections-Generic-List{System-Linq-Expressions-Expression{System-Func{``0,System-Object}}}- "RSM.HCD.CSharp.Core.Utilities.Caching.CacheKeys.GetKey``1(System.Int64,System.String,System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{``0,System.Object}}})")
    -   [GetKey\`\`2(id,includeProperties)](#M-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-GetKey``2-System-Int64,System-Collections-Generic-List{System-Linq-Expressions-Expression{System-Func{``1,System-Object}}}- "RSM.HCD.CSharp.Core.Utilities.Caching.CacheKeys.GetKey``2(System.Int64,System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{``1,System.Object}}})")
    -   [GetKey\`\`2(id,delimiter,includeProperties)](#M-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-GetKey``2-System-Int64,System-String,System-Collections-Generic-List{System-Linq-Expressions-Expression{System-Func{``1,System-Object}}}- "RSM.HCD.CSharp.Core.Utilities.Caching.CacheKeys.GetKey``2(System.Int64,System.String,System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{``1,System.Object}}})")
-   [CacheOptions](#T-AndcultureCode-CSharp-Core-Constants-CacheOptions "RSM.HCD.CSharp.Core.Constants.CacheOptions")
    -   [DAY](#F-AndcultureCode-CSharp-Core-Constants-CacheOptions-DAY "RSM.HCD.CSharp.Core.Constants.CacheOptions.DAY")
    -   [Minutes(minutes)](#M-AndcultureCode-CSharp-Core-Constants-CacheOptions-Minutes-System-Double- "RSM.HCD.CSharp.Core.Constants.CacheOptions.Minutes(System.Double)")
-   [ConfigurationUtils](#T-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils "RSM.HCD.CSharp.Core.Utilities.Configuration.ConfigurationUtils")
    -   [Builder](#P-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-Builder "RSM.HCD.CSharp.Core.Utilities.Configuration.ConfigurationUtils.Builder")
    -   [GetConfiguration()](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-GetConfiguration "RSM.HCD.CSharp.Core.Utilities.Configuration.ConfigurationUtils.GetConfiguration")
    -   [GetConnectionString(name)](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-GetConnectionString-System-String- "RSM.HCD.CSharp.Core.Utilities.Configuration.ConfigurationUtils.GetConnectionString(System.String)")
    -   [SetConfiguration(configuration)](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-SetConfiguration-Microsoft-Extensions-Configuration-IConfigurationRoot- "RSM.HCD.CSharp.Core.Utilities.Configuration.ConfigurationUtils.SetConfiguration(Microsoft.Extensions.Configuration.IConfigurationRoot)")
    -   [SetConnectionString(connectionString)](#M-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-SetConnectionString-System-String- "RSM.HCD.CSharp.Core.Utilities.Configuration.ConfigurationUtils.SetConnectionString(System.String)")
-   [Connection](#T-AndcultureCode-CSharp-Core-Models-Connection "RSM.HCD.CSharp.Core.Models.Connection")
    -   [AdditionalParameters](#P-AndcultureCode-CSharp-Core-Models-Connection-AdditionalParameters "RSM.HCD.CSharp.Core.Models.Connection.AdditionalParameters")
    -   [Database](#P-AndcultureCode-CSharp-Core-Models-Connection-Database "RSM.HCD.CSharp.Core.Models.Connection.Database")
    -   [Datasource](#P-AndcultureCode-CSharp-Core-Models-Connection-Datasource "RSM.HCD.CSharp.Core.Models.Connection.Datasource")
    -   [Password](#P-AndcultureCode-CSharp-Core-Models-Connection-Password "RSM.HCD.CSharp.Core.Models.Connection.Password")
    -   [UserId](#P-AndcultureCode-CSharp-Core-Models-Connection-UserId "RSM.HCD.CSharp.Core.Models.Connection.UserId")
    -   [ToString(delimiter)](#M-AndcultureCode-CSharp-Core-Models-Connection-ToString-System-String- "RSM.HCD.CSharp.Core.Models.Connection.ToString(System.String)")
    -   [ValidParameter(value)](#M-AndcultureCode-CSharp-Core-Models-Connection-ValidParameter-System-String- "RSM.HCD.CSharp.Core.Models.Connection.ValidParameter(System.String)")
-   [ContentTypes](#T-AndcultureCode-CSharp-Core-Constants-ContentTypes "RSM.HCD.CSharp.Core.Constants.ContentTypes")
    -   [CSS](#F-AndcultureCode-CSharp-Core-Constants-ContentTypes-CSS "RSM.HCD.CSharp.Core.Constants.ContentTypes.CSS")
    -   [HTML](#F-AndcultureCode-CSharp-Core-Constants-ContentTypes-HTML "RSM.HCD.CSharp.Core.Constants.ContentTypes.HTML")
    -   [JAVASCRIPT](#F-AndcultureCode-CSharp-Core-Constants-ContentTypes-JAVASCRIPT "RSM.HCD.CSharp.Core.Constants.ContentTypes.JAVASCRIPT")
    -   [JSON](#F-AndcultureCode-CSharp-Core-Constants-ContentTypes-JSON "RSM.HCD.CSharp.Core.Constants.ContentTypes.JSON")
    -   [PDF](#F-AndcultureCode-CSharp-Core-Constants-ContentTypes-PDF "RSM.HCD.CSharp.Core.Constants.ContentTypes.PDF")
    -   [XML](#F-AndcultureCode-CSharp-Core-Constants-ContentTypes-XML "RSM.HCD.CSharp.Core.Constants.ContentTypes.XML")
-   [CookieAuthenticationConfiguration](#T-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration "RSM.HCD.CSharp.Business.Core.Models.Configuration.CookieAuthenticationConfiguration")
    -   [AccessDeniedPath](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-AccessDeniedPath "RSM.HCD.CSharp.Business.Core.Models.Configuration.CookieAuthenticationConfiguration.AccessDeniedPath")
    -   [AuthenticationScheme](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-AuthenticationScheme "RSM.HCD.CSharp.Business.Core.Models.Configuration.CookieAuthenticationConfiguration.AuthenticationScheme")
    -   [CookieName](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-CookieName "RSM.HCD.CSharp.Business.Core.Models.Configuration.CookieAuthenticationConfiguration.CookieName")
    -   [IsEnabled](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-IsEnabled "RSM.HCD.CSharp.Business.Core.Models.Configuration.CookieAuthenticationConfiguration.IsEnabled")
    -   [LoginPath](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-LoginPath "RSM.HCD.CSharp.Business.Core.Models.Configuration.CookieAuthenticationConfiguration.LoginPath")
-   [CoreConfiguration](#T-AndcultureCode-CSharp-Core-Constants-CoreConfiguration "RSM.HCD.CSharp.Core.Constants.CoreConfiguration")
    -   [SEEDS](#F-AndcultureCode-CSharp-Core-Constants-CoreConfiguration-SEEDS "RSM.HCD.CSharp.Core.Constants.CoreConfiguration.SEEDS")
-   [Culture](#T-AndcultureCode-CSharp-Core-Models-Localization-Culture "RSM.HCD.CSharp.Core.Models.Localization.Culture")
    -   [Code](#P-AndcultureCode-CSharp-Core-Models-Localization-Culture-Code "RSM.HCD.CSharp.Core.Models.Localization.Culture.Code")
    -   [CultureTranslations](#P-AndcultureCode-CSharp-Core-Models-Localization-Culture-CultureTranslations "RSM.HCD.CSharp.Core.Models.Localization.Culture.CultureTranslations")
    -   [IsDefault](#P-AndcultureCode-CSharp-Core-Models-Localization-Culture-IsDefault "RSM.HCD.CSharp.Core.Models.Localization.Culture.IsDefault")
-   [CultureTranslation](#T-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation "RSM.HCD.CSharp.Core.Models.Localization.CultureTranslation")
    -   [CultureCode](#P-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation-CultureCode "RSM.HCD.CSharp.Core.Models.Localization.CultureTranslation.CultureCode")
    -   [FilePath](#P-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation-FilePath "RSM.HCD.CSharp.Core.Models.Localization.CultureTranslation.FilePath")
    -   [Key](#P-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation-Key "RSM.HCD.CSharp.Core.Models.Localization.CultureTranslation.Key")
    -   [Value](#P-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation-Value "RSM.HCD.CSharp.Core.Models.Localization.CultureTranslation.Value")
-   [DataConfiguration](#T-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration "RSM.HCD.CSharp.Core.Models.Configuration.DataConfiguration")
    -   [EXTRA_SHORT_STRING_LENGTH](#F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-EXTRA_SHORT_STRING_LENGTH "RSM.HCD.CSharp.Core.Models.Configuration.DataConfiguration.EXTRA_SHORT_STRING_LENGTH")
    -   [IP_ADDRESS_LENGTH](#F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-IP_ADDRESS_LENGTH "RSM.HCD.CSharp.Core.Models.Configuration.DataConfiguration.IP_ADDRESS_LENGTH")
    -   [LONG_DESCRIPTION_LENGTH](#F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-LONG_DESCRIPTION_LENGTH "RSM.HCD.CSharp.Core.Models.Configuration.DataConfiguration.LONG_DESCRIPTION_LENGTH")
    -   [SHORT_DESCRIPTION_LENGTH](#F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-SHORT_DESCRIPTION_LENGTH "RSM.HCD.CSharp.Core.Models.Configuration.DataConfiguration.SHORT_DESCRIPTION_LENGTH")
    -   [SHORT_STRING_LENGTH](#F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-SHORT_STRING_LENGTH "RSM.HCD.CSharp.Core.Models.Configuration.DataConfiguration.SHORT_STRING_LENGTH")
    -   [SHORT_TITLE_LENGTH](#F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-SHORT_TITLE_LENGTH "RSM.HCD.CSharp.Core.Models.Configuration.DataConfiguration.SHORT_TITLE_LENGTH")
    -   [URL_LENGTH](#F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-URL_LENGTH "RSM.HCD.CSharp.Core.Models.Configuration.DataConfiguration.URL_LENGTH")
-   [Deny](#T-AndcultureCode-CSharp-Core-Models-Security-Deny "RSM.HCD.CSharp.Core.Models.Security.Deny")
    -   [#ctor(resource,verb,subject)](#M-AndcultureCode-CSharp-Core-Models-Security-Deny-#ctor-System-String,System-String,System-String- "RSM.HCD.CSharp.Core.Models.Security.Deny.#ctor(System.String,System.String,System.String)")
    -   [Permission](#P-AndcultureCode-CSharp-Core-Models-Security-Deny-Permission "RSM.HCD.CSharp.Core.Models.Security.Deny.Permission")
-   [Do\`1](#T-AndcultureCode-CSharp-Core-Do`1 "RSM.HCD.CSharp.Core.Do`1")
    -   [Finally(logger,workload)](#M-AndcultureCode-CSharp-Core-Do`1-Finally-Microsoft-Extensions-Logging-ILogger,System-Action{AndcultureCode-CSharp-Core-Interfaces-IResult{`0}}- "RSM.HCD.CSharp.Core.Do`1.Finally(Microsoft.Extensions.Logging.ILogger,System.Action{RSM.HCD.CSharp.Core.Interfaces.IResult{`0}})")
    -   [Then(workload,skipIfErrors)](#M-AndcultureCode-CSharp-Core-Do`1-Then-System-Func{AndcultureCode-CSharp-Core-Interfaces-IResult{`0},`0},System-Boolean- "RSM.HCD.CSharp.Core.Do`1.Then(System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{`0},`0},System.Boolean)")
    -   [Try(logger,workload)](#M-AndcultureCode-CSharp-Core-Do`1-Try-Microsoft-Extensions-Logging-ILogger,System-Func{AndcultureCode-CSharp-Core-Interfaces-IResult{`0},`0}- "RSM.HCD.CSharp.Core.Do`1.Try(Microsoft.Extensions.Logging.ILogger,System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{`0},`0})")
    -   [Try(logger,workload,retry)](#M-AndcultureCode-CSharp-Core-Do`1-Try-Microsoft-Extensions-Logging-ILogger,System-UInt32,System-Func{AndcultureCode-CSharp-Core-Interfaces-IResult{`0},`0}- "RSM.HCD.CSharp.Core.Do`1.Try(Microsoft.Extensions.Logging.ILogger,System.UInt32,System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{`0},`0})")
    -   [TrySeed\`\`1(seeds,workload,seedName)](#M-AndcultureCode-CSharp-Core-Do`1-TrySeed``1-AndcultureCode-CSharp-Core-SeedsBase{``0},System-Func{AndcultureCode-CSharp-Core-Interfaces-IResult{`0},`0},System-String- "RSM.HCD.CSharp.Core.Do`1.TrySeed``1(RSM.HCD.CSharp.Core.SeedsBase{``0},System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{`0},`0},System.String)")
-   [EmailProviderBase](#T-AndcultureCode-CSharp-Core-Providers-EmailProviderBase "RSM.HCD.CSharp.Core.Providers.EmailProviderBase")
    -   [Send(message)](#M-AndcultureCode-CSharp-Core-Providers-EmailProviderBase-Send-MimeKit-MimeMessage- "RSM.HCD.CSharp.Core.Providers.EmailProviderBase.Send(MimeKit.MimeMessage)")
    -   [SendLater(message)](#M-AndcultureCode-CSharp-Core-Providers-EmailProviderBase-SendLater-MimeKit-MimeMessage- "RSM.HCD.CSharp.Core.Providers.EmailProviderBase.SendLater(MimeKit.MimeMessage)")
-   [EmailSettings](#T-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings")
    -   [ERROR_MISSING_PROPERTY](#F-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-ERROR_MISSING_PROPERTY "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings.ERROR_MISSING_PROPERTY")
    -   [CustomHeaders](#P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-CustomHeaders "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings.CustomHeaders")
    -   [CustomHeadersAsDictionary](#P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-CustomHeadersAsDictionary "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings.CustomHeadersAsDictionary")
    -   [DeveloperEmailAddress](#P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-DeveloperEmailAddress "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings.DeveloperEmailAddress")
    -   [SendTestEmail](#P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-SendTestEmail "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings.SendTestEmail")
    -   [TestEmailAddress](#P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-TestEmailAddress "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings.TestEmailAddress")
    -   [TestEmailEnvironmentToken](#P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-TestEmailEnvironmentToken "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings.TestEmailEnvironmentToken")
    -   [GetDeveloperEmailAddress(environmentName)](#M-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-GetDeveloperEmailAddress-System-String- "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings.GetDeveloperEmailAddress(System.String)")
    -   [GetRecipientEmailOrTest(email,environmentName,isProduction)](#M-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-GetRecipientEmailOrTest-System-String,System-String,System-Boolean- "RSM.HCD.CSharp.Core.Models.Mail.EmailSettings.GetRecipientEmailOrTest(System.String,System.String,System.Boolean)")
-   [EncryptionUtils](#T-AndcultureCode-CSharp-Core-Utilities-Security-EncryptionUtils "RSM.HCD.CSharp.Core.Utilities.Security.EncryptionUtils")
    -   [GenerateHash(value,salt,iterationCount,bits)](#M-AndcultureCode-CSharp-Core-Utilities-Security-EncryptionUtils-GenerateHash-System-String,System-String,System-Int32,System-UInt16- "RSM.HCD.CSharp.Core.Utilities.Security.EncryptionUtils.GenerateHash(System.String,System.String,System.Int32,System.UInt16)")
    -   [GenerateSalt(bits)](#M-AndcultureCode-CSharp-Core-Utilities-Security-EncryptionUtils-GenerateSalt-System-UInt16- "RSM.HCD.CSharp.Core.Utilities.Security.EncryptionUtils.GenerateSalt(System.UInt16)")
-   [EnglishUnitedStates](#T-AndcultureCode-CSharp-Core-Cultures-EnglishUnitedStates "RSM.HCD.CSharp.Core.Cultures.EnglishUnitedStates")
    -   [Code](#P-AndcultureCode-CSharp-Core-Cultures-EnglishUnitedStates-Code "RSM.HCD.CSharp.Core.Cultures.EnglishUnitedStates.Code")
    -   [IsDefault](#P-AndcultureCode-CSharp-Core-Cultures-EnglishUnitedStates-IsDefault "RSM.HCD.CSharp.Core.Cultures.EnglishUnitedStates.IsDefault")
-   [Entity](#T-AndcultureCode-CSharp-Core-Models-Entities-Entity "RSM.HCD.CSharp.Core.Models.Entities.Entity")
    -   [Id](#P-AndcultureCode-CSharp-Core-Models-Entities-Entity-Id "RSM.HCD.CSharp.Core.Models.Entities.Entity.Id")
-   [EnvironmentConstants](#T-AndcultureCode-CSharp-Core-Constants-EnvironmentConstants "RSM.HCD.CSharp.Core.Constants.EnvironmentConstants")
    -   [TESTING](#F-AndcultureCode-CSharp-Core-Constants-EnvironmentConstants-TESTING "RSM.HCD.CSharp.Core.Constants.EnvironmentConstants.TESTING")
-   [Error](#T-AndcultureCode-CSharp-Core-Models-Errors-Error "RSM.HCD.CSharp.Core.Models.Errors.Error")
    -   [ErrorType](#P-AndcultureCode-CSharp-Core-Models-Errors-Error-ErrorType "RSM.HCD.CSharp.Core.Models.Errors.Error.ErrorType")
    -   [Key](#P-AndcultureCode-CSharp-Core-Models-Errors-Error-Key "RSM.HCD.CSharp.Core.Models.Errors.Error.Key")
    -   [Message](#P-AndcultureCode-CSharp-Core-Models-Errors-Error-Message "RSM.HCD.CSharp.Core.Models.Errors.Error.Message")
-   [ErrorConstants](#T-AndcultureCode-CSharp-Core-Constants-ErrorConstants "RSM.HCD.CSharp.Core.Constants.ErrorConstants")
    -   [ERROR_RESOURCE_NOT_FOUND_KEY](#F-AndcultureCode-CSharp-Core-Constants-ErrorConstants-ERROR_RESOURCE_NOT_FOUND_KEY "RSM.HCD.CSharp.Core.Constants.ErrorConstants.ERROR_RESOURCE_NOT_FOUND_KEY")
-   [GuidUtils](#T-AndcultureCode-CSharp-Core-Utilities-Security-GuidUtils "RSM.HCD.CSharp.Core.Utilities.Security.GuidUtils")
    -   [IsInvalid()](#M-AndcultureCode-CSharp-Core-Utilities-Security-GuidUtils-IsInvalid-System-String- "RSM.HCD.CSharp.Core.Utilities.Security.GuidUtils.IsInvalid(System.String)")
    -   [IsValid()](#M-AndcultureCode-CSharp-Core-Utilities-Security-GuidUtils-IsValid-System-String- "RSM.HCD.CSharp.Core.Utilities.Security.GuidUtils.IsValid(System.String)")
-   [HttpHeaders](#T-AndcultureCode-CSharp-Core-Constants-HttpHeaders "RSM.HCD.CSharp.Core.Constants.HttpHeaders")
    -   [X_FORWARDED_FOR](#F-AndcultureCode-CSharp-Core-Constants-HttpHeaders-X_FORWARDED_FOR "RSM.HCD.CSharp.Core.Constants.HttpHeaders.X_FORWARDED_FOR")
-   [HttpVerb](#T-AndcultureCode-CSharp-Core-Enumerations-HttpVerb "RSM.HCD.CSharp.Core.Enumerations.HttpVerb")
-   [IAndcultureCodeWebHostBuilder](#T-AndcultureCode-CSharp-Core-Interfaces-Hosting-IAndcultureCodeWebHostBuilder "RSM.HCD.CSharp.Core.Interfaces.Hosting.IAndcultureCodeWebHostBuilder")
    -   [Args](#P-AndcultureCode-CSharp-Core-Interfaces-Hosting-IAndcultureCodeWebHostBuilder-Args "RSM.HCD.CSharp.Core.Interfaces.Hosting.IAndcultureCodeWebHostBuilder.Args")
    -   [CreateDefaultBuilder()](#M-AndcultureCode-CSharp-Core-Interfaces-Hosting-IAndcultureCodeWebHostBuilder-CreateDefaultBuilder "RSM.HCD.CSharp.Core.Interfaces.Hosting.IAndcultureCodeWebHostBuilder.CreateDefaultBuilder")
-   [IAndcultureCodeWebHostBuilderExtensions](#T-AndcultureCode-CSharp-Core-Extensions-IAndcultureCodeWebHostBuilderExtensions "RSM.HCD.CSharp.Core.Extensions.IAndcultureCodeWebHostBuilderExtensions")
    -   [ASPNETCORE_ENVIRONMENT](#F-AndcultureCode-CSharp-Core-Extensions-IAndcultureCodeWebHostBuilderExtensions-ASPNETCORE_ENVIRONMENT "RSM.HCD.CSharp.Core.Extensions.IAndcultureCodeWebHostBuilderExtensions.ASPNETCORE_ENVIRONMENT")
    -   [PreloadAmazonElasticBeanstalk(builder,stdoutEnabled,configurationProvider)](#M-AndcultureCode-CSharp-Core-Extensions-IAndcultureCodeWebHostBuilderExtensions-PreloadAmazonElasticBeanstalk-AndcultureCode-CSharp-Core-Interfaces-Hosting-IAndcultureCodeWebHostBuilder,System-Boolean,AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider- "RSM.HCD.CSharp.Core.Extensions.IAndcultureCodeWebHostBuilderExtensions.PreloadAmazonElasticBeanstalk(RSM.HCD.CSharp.Core.Interfaces.Hosting.IAndcultureCodeWebHostBuilder,System.Boolean,RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider)")
-   [IApplicationContext](#T-AndcultureCode-CSharp-Core-Interfaces-Data-IApplicationContext "RSM.HCD.CSharp.Core.Interfaces.Data.IApplicationContext")
    -   [Acls](#P-AndcultureCode-CSharp-Core-Interfaces-Data-IApplicationContext-Acls "RSM.HCD.CSharp.Core.Interfaces.Data.IApplicationContext.Acls")
-   [IConfigurationBuilderExtensions](#T-AndcultureCode-CSharp-Core-Extensions-IConfigurationBuilderExtensions "RSM.HCD.CSharp.Core.Extensions.IConfigurationBuilderExtensions")
    -   [AddAmazonElasticBeanstalk(configurationBuilder)](#M-AndcultureCode-CSharp-Core-Extensions-IConfigurationBuilderExtensions-AddAmazonElasticBeanstalk-Microsoft-Extensions-Configuration-IConfigurationBuilder- "RSM.HCD.CSharp.Core.Extensions.IConfigurationBuilderExtensions.AddAmazonElasticBeanstalk(Microsoft.Extensions.Configuration.IConfigurationBuilder)")
-   [IConnection](#T-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection "RSM.HCD.CSharp.Core.Interfaces.Data.IConnection")
    -   [AdditionalParameters](#P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-AdditionalParameters "RSM.HCD.CSharp.Core.Interfaces.Data.IConnection.AdditionalParameters")
    -   [Database](#P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-Database "RSM.HCD.CSharp.Core.Interfaces.Data.IConnection.Database")
    -   [Datasource](#P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-Datasource "RSM.HCD.CSharp.Core.Interfaces.Data.IConnection.Datasource")
    -   [Password](#P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-Password "RSM.HCD.CSharp.Core.Interfaces.Data.IConnection.Password")
    -   [UserId](#P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-UserId "RSM.HCD.CSharp.Core.Interfaces.Data.IConnection.UserId")
    -   [ToString()](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-ToString-System-String- "RSM.HCD.CSharp.Core.Interfaces.Data.IConnection.ToString(System.String)")
-   [ICulture](#T-AndcultureCode-CSharp-Core-Interfaces-ICulture "RSM.HCD.CSharp.Core.Interfaces.ICulture")
    -   [Code](#P-AndcultureCode-CSharp-Core-Interfaces-ICulture-Code "RSM.HCD.CSharp.Core.Interfaces.ICulture.Code")
    -   [IsDefault](#P-AndcultureCode-CSharp-Core-Interfaces-ICulture-IsDefault "RSM.HCD.CSharp.Core.Interfaces.ICulture.IsDefault")
-   [ICultureExtensions](#T-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions "RSM.HCD.CSharp.Core.Extensions.ICultureExtensions")
    -   [Default(cultures)](#M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-Default-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture}- "RSM.HCD.CSharp.Core.Extensions.ICultureExtensions.Default(System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture})")
    -   [Exists(cultures,cultureCode)](#M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-Exists-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture},System-String- "RSM.HCD.CSharp.Core.Extensions.ICultureExtensions.Exists(System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture},System.String)")
    -   [ToCultureCodes(cultures)](#M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-ToCultureCodes-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture}- "RSM.HCD.CSharp.Core.Extensions.ICultureExtensions.ToCultureCodes(System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture})")
    -   [ToCultureCodes(cultures,delimiter)](#M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-ToCultureCodes-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture},System-String- "RSM.HCD.CSharp.Core.Extensions.ICultureExtensions.ToCultureCodes(System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture},System.String)")
    -   [ToCultureInfo(culture)](#M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-ToCultureInfo-AndcultureCode-CSharp-Core-Interfaces-ICulture- "RSM.HCD.CSharp.Core.Extensions.ICultureExtensions.ToCultureInfo(RSM.HCD.CSharp.Core.Interfaces.ICulture)")
    -   [ToCultureInfos(cultures)](#M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-ToCultureInfos-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture}- "RSM.HCD.CSharp.Core.Extensions.ICultureExtensions.ToCultureInfos(System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture})")
-   [IDistributedCacheExtensions](#T-AndcultureCode-CSharp-Core-Extensions-IDistributedCacheExtensions "RSM.HCD.CSharp.Core.Extensions.IDistributedCacheExtensions")
    -   [Get\`\`1(cache,key)](#M-AndcultureCode-CSharp-Core-Extensions-IDistributedCacheExtensions-Get``1-Microsoft-Extensions-Caching-Distributed-IDistributedCache,System-String- "RSM.HCD.CSharp.Core.Extensions.IDistributedCacheExtensions.Get``1(Microsoft.Extensions.Caching.Distributed.IDistributedCache,System.String)")
    -   [Serialize\`\`1(cache,value)](#M-AndcultureCode-CSharp-Core-Extensions-IDistributedCacheExtensions-Serialize``1-Microsoft-Extensions-Caching-Distributed-IDistributedCache,``0- "RSM.HCD.CSharp.Core.Extensions.IDistributedCacheExtensions.Serialize``1(Microsoft.Extensions.Caching.Distributed.IDistributedCache,``0)")
    -   [Set\`\`1(cache,key,value,options)](#M-AndcultureCode-CSharp-Core-Extensions-IDistributedCacheExtensions-Set``1-Microsoft-Extensions-Caching-Distributed-IDistributedCache,System-String,``0,Microsoft-Extensions-Caching-Distributed-DistributedCacheEntryOptions- "RSM.HCD.CSharp.Core.Extensions.IDistributedCacheExtensions.Set``1(Microsoft.Extensions.Caching.Distributed.IDistributedCache,System.String,``0,Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions)")
-   [IEmailProvider](#T-AndcultureCode-CSharp-Core-Interfaces-Providers-Mail-IEmailProvider "RSM.HCD.CSharp.Core.Interfaces.Providers.Mail.IEmailProvider")
    -   [Send(message)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Mail-IEmailProvider-Send-MimeKit-MimeMessage- "RSM.HCD.CSharp.Core.Interfaces.Providers.Mail.IEmailProvider.Send(MimeKit.MimeMessage)")
    -   [SendLater(message)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Mail-IEmailProvider-SendLater-MimeKit-MimeMessage- "RSM.HCD.CSharp.Core.Interfaces.Providers.Mail.IEmailProvider.SendLater(MimeKit.MimeMessage)")
-   [ILockingConductor\`1](#T-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1 "RSM.HCD.CSharp.Core.Interfaces.Conductors.ILockingConductor`1")
    -   [ExtendLock(id,lockUntil,updatedById)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1-ExtendLock-System-Int64,System-DateTimeOffset,System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.ILockingConductor`1.ExtendLock(System.Int64,System.DateTimeOffset,System.Nullable{System.Int64})")
    -   [Lock(id,lockUntil,lockedById)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1-Lock-System-Int64,System-DateTimeOffset,System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.ILockingConductor`1.Lock(System.Int64,System.DateTimeOffset,System.Nullable{System.Int64})")
    -   [Unlock(id,unlockedById)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1-Unlock-System-Int64,System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.ILockingConductor`1.Unlock(System.Int64,System.Nullable{System.Int64})")
    -   [ValidateLock(item,currentUserId)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1-ValidateLock-`0,System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.ILockingConductor`1.ValidateLock(`0,System.Nullable{System.Int64})")
-   [IOAuthUser](#T-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser "RSM.HCD.CSharp.Core.Interfaces.Authentication.IOAuthUser")
    -   [Email](#P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-Email "RSM.HCD.CSharp.Core.Interfaces.Authentication.IOAuthUser.Email")
    -   [FirstName](#P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-FirstName "RSM.HCD.CSharp.Core.Interfaces.Authentication.IOAuthUser.FirstName")
    -   [Id](#P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-Id "RSM.HCD.CSharp.Core.Interfaces.Authentication.IOAuthUser.Id")
    -   [LastName](#P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-LastName "RSM.HCD.CSharp.Core.Interfaces.Authentication.IOAuthUser.LastName")
    -   [UserMetadataName](#P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-UserMetadataName "RSM.HCD.CSharp.Core.Interfaces.Authentication.IOAuthUser.UserMetadataName")
-   [IPermissionConductor](#T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IPermissionConductor "RSM.HCD.CSharp.Core.Interfaces.Conductors.IPermissionConductor")
    -   [GetAcls(resource,verb)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IPermissionConductor-GetAcls-System-String,System-String- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IPermissionConductor.GetAcls(System.String,System.String)")
    -   [IsAllowed(resource,verb,subject)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IPermissionConductor-IsAllowed-System-String,System-String,System-String- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IPermissionConductor.IsAllowed(System.String,System.String,System.String)")
-   [IProvider](#T-AndcultureCode-CSharp-Core-Interfaces-Providers-IProvider "RSM.HCD.CSharp.Core.Interfaces.Providers.IProvider")
    -   [Implemented](#P-AndcultureCode-CSharp-Core-Interfaces-Providers-IProvider-Implemented "RSM.HCD.CSharp.Core.Interfaces.Providers.IProvider.Implemented")
    -   [Name](#P-AndcultureCode-CSharp-Core-Interfaces-Providers-IProvider-Name "RSM.HCD.CSharp.Core.Interfaces.Providers.IProvider.Name")
-   [IRemoteAccessDetails](#T-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IRemoteAccessDetails "RSM.HCD.CSharp.Core.Interfaces.Providers.Storage.IRemoteAccessDetails")
    -   [Url](#P-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IRemoteAccessDetails-Url "RSM.HCD.CSharp.Core.Interfaces.Providers.Storage.IRemoteAccessDetails.Url")
-   [IRepositoryConductor\`1](#T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1 "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryConductor`1")
    -   [CommandTimeout](#P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1-CommandTimeout "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryConductor`1.CommandTimeout")
    -   [BulkCreateOrUpdate()](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1-BulkCreateOrUpdate-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryConductor`1.BulkCreateOrUpdate(System.Collections.Generic.IEnumerable{`0},System.Nullable{System.Int64})")
    -   [CreateOrUpdate()](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1-CreateOrUpdate-`0,System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryConductor`1.CreateOrUpdate(`0,System.Nullable{System.Int64})")
    -   [CreateOrUpdate(items,createdOrUpdatedById)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1-CreateOrUpdate-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryConductor`1.CreateOrUpdate(System.Collections.Generic.IEnumerable{`0},System.Nullable{System.Int64})")
-   [IRepositoryCreateConductor\`1](#T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryCreateConductor`1 "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryCreateConductor`1")
    -   [CommandTimeout](#P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryCreateConductor`1-CommandTimeout "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryCreateConductor`1.CommandTimeout")
    -   [BulkCreateDistinct\`\`1(items,property,createdById)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryCreateConductor`1-BulkCreateDistinct``1-System-Collections-Generic-IEnumerable{`0},System-Func{`0,``0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryCreateConductor`1.BulkCreateDistinct``1(System.Collections.Generic.IEnumerable{`0},System.Func{`0,``0},System.Nullable{System.Int64})")
    -   [CreateDistinct\`\`1(items,property,createdById)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryCreateConductor`1-CreateDistinct``1-System-Collections-Generic-IEnumerable{`0},System-Func{`0,``0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryCreateConductor`1.CreateDistinct``1(System.Collections.Generic.IEnumerable{`0},System.Func{`0,``0},System.Nullable{System.Int64})")
-   [IRepositoryDeleteConductor\`1](#T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryDeleteConductor`1 "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryDeleteConductor`1")
    -   [CommandTimeout](#P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryDeleteConductor`1-CommandTimeout "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryDeleteConductor`1.CommandTimeout")
-   [IRepositoryReadConductor\`1](#T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1 "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1")
    -   [CommandTimeout](#P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-CommandTimeout "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.CommandTimeout")
    -   [FindAll(filter,orderBy,includeProperties,skip,take,ignoreQueryFilters,asNoTracking)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAll-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindAll(System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}},System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}},System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Boolean},System.Boolean)")
    -   [FindAll(filter,orderBy,nextLinkParams,ignoreQueryFilters,asNoTracking)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAll-System-Collections-Generic-Dictionary{System-String,System-String},System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Nullable{System-Boolean},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindAll(System.Collections.Generic.Dictionary{System.String,System.String},System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}},System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}},System.Nullable{System.Boolean},System.Boolean)")
    -   [FindAllCommitted(filter,orderBy,includeProperties,skip,take,ignoreQueryFilters)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAllCommitted-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindAllCommitted(System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}},System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}},System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Boolean})")
    -   [FindAllCommitted(filter,orderBy,nextLinkParams,ignoreQueryFilters)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAllCommitted-System-Collections-Generic-Dictionary{System-String,System-String},System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Nullable{System-Boolean}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindAllCommitted(System.Collections.Generic.Dictionary{System.String,System.String},System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}},System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}},System.Nullable{System.Boolean})")
    -   [FindAll\`\`1(filter,orderBy,groupBy,includeProperties,skip,take,ignoreQueryFilters,asNoTracking)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAll``1-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Linq-Expressions-Expression{System-Func{`0,``0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindAll``1(System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}},System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}},System.Linq.Expressions.Expression{System.Func{`0,``0}},System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Boolean},System.Boolean)")
    -   [FindAll\`\`2(filter,orderBy,groupBy,groupBySelector,includeProperties,skip,take,ignoreQueryFilters,asNoTracking)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAll``2-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Linq-Expressions-Expression{System-Func{`0,``0}},System-Linq-Expressions-Expression{System-Func{``0,System-Collections-Generic-IEnumerable{`0},``1}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindAll``2(System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}},System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}},System.Linq.Expressions.Expression{System.Func{`0,``0}},System.Linq.Expressions.Expression{System.Func{``0,System.Collections.Generic.IEnumerable{`0},``1}},System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Boolean},System.Boolean)")
    -   [FindById(id)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindById(System.Int64)")
    -   [FindById(id,filter)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindById(System.Int64,System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}})")
    -   [FindById(id,includeProperties)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64,System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindById(System.Int64,System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[])")
    -   [FindById(id,ignoreQueryFilters,includeProperties)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64,System-Boolean,System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindById(System.Int64,System.Boolean,System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[])")
    -   [FindById(id,includeProperties)](#M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64,System-String[]- "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryReadConductor`1.FindById(System.Int64,System.String[])")
-   [IRepositoryUpdateConductor\`1](#T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryUpdateConductor`1 "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryUpdateConductor`1")
    -   [CommandTimeout](#P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryUpdateConductor`1-CommandTimeout "RSM.HCD.CSharp.Core.Interfaces.Conductors.IRepositoryUpdateConductor`1.CommandTimeout")
-   [IRepository\`1](#T-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1 "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1")
    -   [CommandTimeout](#P-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-CommandTimeout "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.CommandTimeout")
    -   [BulkCreate(items,createdById)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-BulkCreate-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.BulkCreate(System.Collections.Generic.IEnumerable{`0},System.Nullable{System.Int64})")
    -   [BulkCreateDistinct\`\`1(items,property,createdById,items,property,createdById)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-BulkCreateDistinct``1-System-Collections-Generic-IEnumerable{`0},System-Func{`0,``0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.BulkCreateDistinct``1(System.Collections.Generic.IEnumerable{`0},System.Func{`0,``0},System.Nullable{System.Int64})")
    -   [BulkDelete(items,deletedById,soft)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-BulkDelete-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.BulkDelete(System.Collections.Generic.IEnumerable{`0},System.Nullable{System.Int64},System.Boolean)")
    -   [BulkUpdate(entities,updatedBy)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-BulkUpdate-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.BulkUpdate(System.Collections.Generic.IEnumerable{`0},System.Nullable{System.Int64})")
    -   [Create(item,createdById)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Create-`0,System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.Create(`0,System.Nullable{System.Int64})")
    -   [Create(items,createdById)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Create-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.Create(System.Collections.Generic.IEnumerable{`0},System.Nullable{System.Int64})")
    -   [CreateDistinct\`\`1(items,property,createdById)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-CreateDistinct``1-System-Collections-Generic-IEnumerable{`0},System-Func{`0,``0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.CreateDistinct``1(System.Collections.Generic.IEnumerable{`0},System.Func{`0,``0},System.Nullable{System.Int64})")
    -   [Delete(id,deletedById,soft)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Delete-System-Int64,System-Nullable{System-Int64},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.Delete(System.Int64,System.Nullable{System.Int64},System.Boolean)")
    -   [Delete(o,deletedById,soft)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Delete-`0,System-Nullable{System-Int64},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.Delete(`0,System.Nullable{System.Int64},System.Boolean)")
    -   [Delete(items,deletedById,batchSize,soft)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Delete-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64},System-Int64,System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.Delete(System.Collections.Generic.IEnumerable{`0},System.Nullable{System.Int64},System.Int64,System.Boolean)")
    -   [FindAll(filter,orderBy,includeProperties,skip,take,ignoreQueryFilters,asNoTracking)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindAll-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.FindAll(System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}},System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}},System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Boolean},System.Boolean)")
    -   [FindAll\`\`1(filter,orderBy,groupBy,includeProperties,skip,take,ignoreQueryFilters,asNoTracking)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindAll``1-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Linq-Expressions-Expression{System-Func{`0,``0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.FindAll``1(System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}},System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}},System.Linq.Expressions.Expression{System.Func{`0,``0}},System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Boolean},System.Boolean)")
    -   [FindAll\`\`2(filter,orderBy,groupBy,groupBySelector,includeProperties,skip,take,ignoreQueryFilters,asNoTracking)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindAll``2-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Linq-Expressions-Expression{System-Func{`0,``0}},System-Linq-Expressions-Expression{System-Func{``0,System-Collections-Generic-IEnumerable{`0},``1}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.FindAll``2(System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}},System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}},System.Linq.Expressions.Expression{System.Func{`0,``0}},System.Linq.Expressions.Expression{System.Func{``0,System.Collections.Generic.IEnumerable{`0},``1}},System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.Nullable{System.Boolean},System.Boolean)")
    -   [FindById(id,ignoreQueryFilters)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-Nullable{System-Boolean}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.FindById(System.Int64,System.Nullable{System.Boolean})")
    -   [FindById(id,filter)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.FindById(System.Int64,System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}})")
    -   [FindById(id,includeProperties)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.FindById(System.Int64,System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[])")
    -   [FindById(id,ignoreQueryFilters,includeProperties)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-Nullable{System-Boolean},System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.FindById(System.Int64,System.Nullable{System.Boolean},System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[])")
    -   [FindById(id,includeProperties)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-String[]- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.FindById(System.Int64,System.String[])")
    -   [Restore(o)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Restore-`0- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.Restore(`0)")
    -   [Restore(id)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Restore-System-Int64- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.Restore(System.Int64)")
    -   [Update(item,updatedBy)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Update-`0,System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.Update(`0,System.Nullable{System.Int64})")
    -   [Update(entities,updatedBy)](#M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Update-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Interfaces.Data.IRepository`1.Update(System.Collections.Generic.IEnumerable{`0},System.Nullable{System.Int64})")
-   [IResultExtensions](#T-AndcultureCode-CSharp-Core-Extensions-IResultExtensions "RSM.HCD.CSharp.Core.Extensions.IResultExtensions")
    -   [AddErrorAndLog\`\`1(result,logger,errorKey,errorMessage,resourceIdentifier)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,System-String,System-String,System-Nullable{System-Int64}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrorAndLog``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Logging.ILogger,System.String,System.String,System.Nullable{System.Int64})")
    -   [AddErrorAndLog\`\`1(result,logger,localizer,errorKey,arguments)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Object[]- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrorAndLog``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Logging.ILogger,Microsoft.Extensions.Localization.IStringLocalizer,System.String,System.Object[])")
    -   [AddErrorAndLog\`\`1(result,logger,localizer,errorKey,resourceIdentifier,arguments)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Int64,System-Object[]- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrorAndLog``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Logging.ILogger,Microsoft.Extensions.Localization.IStringLocalizer,System.String,System.Int64,System.Object[])")
    -   [AddError\`\`1(result,localizer,key,arguments)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Object[]- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddError``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Localization.IStringLocalizer,System.String,System.Object[])")
    -   [AddError\`\`1(result,error)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Interfaces-IError- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddError``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},RSM.HCD.CSharp.Core.Interfaces.IError)")
    -   [AddError\`\`1(result,errorType,key,message)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Enumerations-ErrorType,System-String,System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddError``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},RSM.HCD.CSharp.Core.Enumerations.ErrorType,System.String,System.String)")
    -   [AddError\`\`1(result,localizer,key,arguments)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Localization-IStringLocalizer,AndcultureCode-CSharp-Core-Enumerations-ErrorType,System-String,System-Object[]- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddError``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Localization.IStringLocalizer,RSM.HCD.CSharp.Core.Enumerations.ErrorType,System.String,System.Object[])")
    -   [AddError\`\`1(result,key,message)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddError``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String,System.String)")
    -   [AddError\`\`1(result,message)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddError``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String)")
    -   [AddErrorsAndLog\`\`1(result,logger,errorKey,errorMessage,resourceIdentifier,errors)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,System-String,System-String,System-Int64,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrorsAndLog``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Logging.ILogger,System.String,System.String,System.Int64,System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError})")
    -   [AddErrorsAndLog\`\`1(result,logger,errorKey,errorMessage,errors)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,System-String,System-String,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrorsAndLog``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Logging.ILogger,System.String,System.String,System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError})")
    -   [AddErrorsAndLog\`\`1(result,logger,errorKey,errorMessage,logMessage,resourceIdentifier,errors,methodName)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,System-String,System-String,System-String,System-String,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrorsAndLog``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Logging.ILogger,System.String,System.String,System.String,System.String,System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError},System.String)")
    -   [AddErrorsAndLog\`\`1(result,logger,localizer,errorKey,resourceIdentifier,errors,arguments)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Int64,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},System-Object[]- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrorsAndLog``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Logging.ILogger,Microsoft.Extensions.Localization.IStringLocalizer,System.String,System.Int64,System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError},System.Object[])")
    -   [AddErrorsAndReturnDefault\`\`2(destination,source)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndReturnDefault``2-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Interfaces-IResult{``1}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrorsAndReturnDefault``2(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},RSM.HCD.CSharp.Core.Interfaces.IResult{``1})")
    -   [AddErrors\`\`1(result,errors)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError})")
    -   [AddErrors\`\`2(destination,source)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrors``2-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Interfaces-IResult{``1}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddErrors``2(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},RSM.HCD.CSharp.Core.Interfaces.IResult{``1})")
    -   [AddExceptionError\`\`1(result,key,exception)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddExceptionError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-Exception- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddExceptionError``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String,System.Exception)")
    -   [AddNextLinkParam\`\`1(result,key,value)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddNextLinkParam``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddNextLinkParam``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String,System.String)")
    -   [AddNextLinkParam\`\`1(result,key,value)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddNextLinkParam``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-Int32- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddNextLinkParam``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String,System.Int32)")
    -   [AddNextLinkParams\`\`1(destinationResult,sourceResult)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddNextLinkParams``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Interfaces-IResult{``0}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddNextLinkParams``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},RSM.HCD.CSharp.Core.Interfaces.IResult{``0})")
    -   [AddValidationError\`\`1(result,key,message)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddValidationError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddValidationError``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String,System.String)")
    -   [AddValidationError\`\`1(result,localizer,key,arguments)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddValidationError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Object[]- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.AddValidationError``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},Microsoft.Extensions.Localization.IStringLocalizer,System.String,System.Object[])")
    -   [DoesNotHaveErrors\`\`1(result,errorType)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-DoesNotHaveErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Enumerations-ErrorType- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.DoesNotHaveErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},RSM.HCD.CSharp.Core.Enumerations.ErrorType)")
    -   [DoesNotHaveErrors\`\`1(result,key)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-DoesNotHaveErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.DoesNotHaveErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String)")
    -   [GetErrors\`\`1(result,errorType)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-GetErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Enumerations-ErrorType- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.GetErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},RSM.HCD.CSharp.Core.Enumerations.ErrorType)")
    -   [GetErrors\`\`1(result,key)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-GetErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.GetErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String)")
    -   [GetValidationErrors\`\`1(result)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-GetValidationErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.GetValidationErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0})")
    -   [HasErrorsOrResultIsFalse(result)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrorsOrResultIsFalse-AndcultureCode-CSharp-Core-Interfaces-IResult{System-Boolean}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.HasErrorsOrResultIsFalse(RSM.HCD.CSharp.Core.Interfaces.IResult{System.Boolean})")
    -   [HasErrorsOrResultIsNull\`\`1(result)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrorsOrResultIsNull``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.HasErrorsOrResultIsNull``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0})")
    -   [HasErrors\`\`1(resultList,errorType)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IResult{``0}},AndcultureCode-CSharp-Core-Enumerations-ErrorType- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.HasErrors``1(System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{``0}},RSM.HCD.CSharp.Core.Enumerations.ErrorType)")
    -   [HasErrors\`\`1(resultList,key)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IResult{``0}},System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.HasErrors``1(System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{``0}},System.String)")
    -   [HasErrors\`\`1(resultList)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IResult{``0}}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.HasErrors``1(System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{``0}})")
    -   [HasErrors\`\`1(result,errorType)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Enumerations-ErrorType- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.HasErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},RSM.HCD.CSharp.Core.Enumerations.ErrorType)")
    -   [HasErrors\`\`1(result,key)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.HasErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String)")
    -   [HasValidationErrors\`\`1(result)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasValidationErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0}- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.HasValidationErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0})")
    -   [ListErrors\`\`1(resultList,delimiter)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ListErrors``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IResult{``0}},System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.ListErrors``1(System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{``0}},System.String)")
    -   [ListErrors\`\`1(result,delimiter)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ListErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.ListErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.String)")
    -   [ThrowIfAnyErrorsOrResultIsFalse(result,hasErrorsException,resultNullException)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ThrowIfAnyErrorsOrResultIsFalse-AndcultureCode-CSharp-Core-Interfaces-IResult{System-Boolean},System-Exception,System-Exception- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.ThrowIfAnyErrorsOrResultIsFalse(RSM.HCD.CSharp.Core.Interfaces.IResult{System.Boolean},System.Exception,System.Exception)")
    -   [ThrowIfAnyErrorsOrResultIsNull\`\`1(result,hasErrorsException,resultNullException)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ThrowIfAnyErrorsOrResultIsNull``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-Exception,System-Exception- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.ThrowIfAnyErrorsOrResultIsNull``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.Exception,System.Exception)")
    -   [ThrowIfAnyErrors\`\`1(result,customException)](#M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ThrowIfAnyErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-Exception- "RSM.HCD.CSharp.Core.Extensions.IResultExtensions.ThrowIfAnyErrors``1(RSM.HCD.CSharp.Core.Interfaces.IResult{``0},System.Exception)")
-   [IResult\`1](#T-AndcultureCode-CSharp-Core-Interfaces-IResult`1 "RSM.HCD.CSharp.Core.Interfaces.IResult`1")
    -   [ErrorCount](#P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-ErrorCount "RSM.HCD.CSharp.Core.Interfaces.IResult`1.ErrorCount")
    -   [Errors](#P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-Errors "RSM.HCD.CSharp.Core.Interfaces.IResult`1.Errors")
    -   [HasErrors](#P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-HasErrors "RSM.HCD.CSharp.Core.Interfaces.IResult`1.HasErrors")
    -   [NextLinkParams](#P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-NextLinkParams "RSM.HCD.CSharp.Core.Interfaces.IResult`1.NextLinkParams")
    -   [ResultObject](#P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-ResultObject "RSM.HCD.CSharp.Core.Interfaces.IResult`1.ResultObject")
-   [IRole](#T-AndcultureCode-CSharp-Core-Interfaces-Entity-IRole "RSM.HCD.CSharp.Core.Interfaces.Entity.IRole")
    -   [Description](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IRole-Description "RSM.HCD.CSharp.Core.Interfaces.Entity.IRole.Description")
    -   [Name](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IRole-Name "RSM.HCD.CSharp.Core.Interfaces.Entity.IRole.Name")
-   [IServiceCollectionExtensions](#T-AndcultureCode-CSharp-Core-Extensions-IServiceCollectionExtensions "RSM.HCD.CSharp.Core.Extensions.IServiceCollectionExtensions")
    -   [AddSeeding(services,configuration)](#M-AndcultureCode-CSharp-Core-Extensions-IServiceCollectionExtensions-AddSeeding-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfigurationRoot- "RSM.HCD.CSharp.Core.Extensions.IServiceCollectionExtensions.AddSeeding(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfigurationRoot)")
-   [IStorageProvider](#T-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider "RSM.HCD.CSharp.Core.Interfaces.Providers.Storage.IStorageProvider")
    -   [Copy(srcRelativeProviderPath,srcStorageContainer,destRelativeProviderPath,destStorageContainer,srcPathToCopy,destPathToCopy)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-Copy-System-String,System-String,System-String,System-String,System-String,System-String- "RSM.HCD.CSharp.Core.Interfaces.Providers.Storage.IStorageProvider.Copy(System.String,System.String,System.String,System.String,System.String,System.String)")
    -   [Download(relativeProviderPath,storageContainer,pathToSave)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-Download-System-String,System-String,System-String- "RSM.HCD.CSharp.Core.Interfaces.Providers.Storage.IStorageProvider.Download(System.String,System.String,System.String)")
    -   [FileExists(relativeProviderPath,storageContainer)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-FileExists-System-String,System-String- "RSM.HCD.CSharp.Core.Interfaces.Providers.Storage.IStorageProvider.FileExists(System.String,System.String)")
    -   [GetFile(relativeProviderPath,storageContainer)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-GetFile-System-String,System-String- "RSM.HCD.CSharp.Core.Interfaces.Providers.Storage.IStorageProvider.GetFile(System.String,System.String)")
    -   [GetRemoteAccessDetails(relativeProviderPath,storageContainer,expiryTime,httpVerb,contentType)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-GetRemoteAccessDetails-System-String,System-String,System-Nullable{System-DateTimeOffset},AndcultureCode-CSharp-Core-Enumerations-HttpVerb,System-String- "RSM.HCD.CSharp.Core.Interfaces.Providers.Storage.IStorageProvider.GetRemoteAccessDetails(System.String,System.String,System.Nullable{System.DateTimeOffset},RSM.HCD.CSharp.Core.Enumerations.HttpVerb,System.String)")
-   [IStringLocalizerExtensions](#T-AndcultureCode-CSharp-Core-Extensions-IStringLocalizerExtensions "RSM.HCD.CSharp.Core.Extensions.IStringLocalizerExtensions")
    -   [Default(localizer,key,arguments)](#M-AndcultureCode-CSharp-Core-Extensions-IStringLocalizerExtensions-Default-Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Object[]- "RSM.HCD.CSharp.Core.Extensions.IStringLocalizerExtensions.Default(Microsoft.Extensions.Localization.IStringLocalizer,System.String,System.Object[])")
-   [IUser](#T-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser "RSM.HCD.CSharp.Core.Interfaces.Entity.IUser")
    -   [Email](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-Email "RSM.HCD.CSharp.Core.Interfaces.Entity.IUser.Email")
    -   [FirstName](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-FirstName "RSM.HCD.CSharp.Core.Interfaces.Entity.IUser.FirstName")
    -   [IsSuperAdmin](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-IsSuperAdmin "RSM.HCD.CSharp.Core.Interfaces.Entity.IUser.IsSuperAdmin")
    -   [LastName](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-LastName "RSM.HCD.CSharp.Core.Interfaces.Entity.IUser.LastName")
    -   [PasswordHash](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-PasswordHash "RSM.HCD.CSharp.Core.Interfaces.Entity.IUser.PasswordHash")
    -   [Salt](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-Salt "RSM.HCD.CSharp.Core.Interfaces.Entity.IUser.Salt")
    -   [SecurityStamp](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-SecurityStamp "RSM.HCD.CSharp.Core.Interfaces.Entity.IUser.SecurityStamp")
    -   [UserName](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-UserName "RSM.HCD.CSharp.Core.Interfaces.Entity.IUser.UserName")
-   [IUserLogin](#T-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin")
    -   [FailedAttemptCount](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-FailedAttemptCount "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.FailedAttemptCount")
    -   [Ip](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-Ip "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.Ip")
    -   [IsSuccessful](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-IsSuccessful "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.IsSuccessful")
    -   [Role](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-Role "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.Role")
    -   [RoleId](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-RoleId "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.RoleId")
    -   [ServerName](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-ServerName "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.ServerName")
    -   [User](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-User "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.User")
    -   [UserAgent](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-UserAgent "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.UserAgent")
    -   [UserId](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-UserId "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.UserId")
    -   [UserName](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-UserName "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserLogin.UserName")
-   [IUserMetadata](#T-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserMetadata")
    -   [IsNameEditable](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-IsNameEditable "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserMetadata.IsNameEditable")
    -   [Name](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-Name "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserMetadata.Name")
    -   [Role](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-Role "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserMetadata.Role")
    -   [RoleId](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-RoleId "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserMetadata.RoleId")
    -   [Type](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-Type "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserMetadata.Type")
    -   [User](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-User "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserMetadata.User")
    -   [UserId](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-UserId "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserMetadata.UserId")
    -   [Value](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-Value "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserMetadata.Value")
-   [IUserRole](#T-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserRole")
    -   [Role](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole-Role "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserRole.Role")
    -   [RoleId](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole-RoleId "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserRole.RoleId")
    -   [User](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole-User "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserRole.User")
    -   [UserId](#P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole-UserId "RSM.HCD.CSharp.Core.Interfaces.Entity.IUserRole.UserId")
-   [IWorkerProvider](#T-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider")
    -   [Delete(id)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Delete-System-String- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Delete(System.String)")
    -   [DeletedCount()](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-DeletedCount "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.DeletedCount")
    -   [Enqueue(methodCall)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Enqueue-System-Linq-Expressions-Expression{System-Action}- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Enqueue(System.Linq.Expressions.Expression{System.Action})")
    -   [Enqueue\`\`1(methodCall)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Enqueue``1-System-Linq-Expressions-Expression{System-Action{``0}}- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Enqueue``1(System.Linq.Expressions.Expression{System.Action{``0}})")
    -   [EnqueuedCount(queue)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-EnqueuedCount-System-String- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.EnqueuedCount(System.String)")
    -   [Recur(identifier,methodCall,recurringOptions)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Recur-System-String,System-Linq-Expressions-Expression{System-Action},AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Recur(System.String,System.Linq.Expressions.Expression{System.Action},RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption)")
    -   [Recur\`\`1(identifier,methodCall,chronExpression)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Recur``1-System-String,System-Linq-Expressions-Expression{System-Action{``0}},System-String- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Recur``1(System.String,System.Linq.Expressions.Expression{System.Action{``0}},System.String)")
    -   [Recur\`\`1(identifier,methodCall,recurringOptions)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Recur``1-System-String,System-Linq-Expressions-Expression{System-Action{``0}},AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Recur``1(System.String,System.Linq.Expressions.Expression{System.Action{``0}},RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption)")
    -   [RecurringCount()](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-RecurringCount "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.RecurringCount")
    -   [RemoveRecurrence(identifier)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-RemoveRecurrence-System-String- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.RemoveRecurrence(System.String)")
    -   [Schedule(methodCall,delay)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Schedule-System-Linq-Expressions-Expression{System-Action},System-TimeSpan- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Schedule(System.Linq.Expressions.Expression{System.Action},System.TimeSpan)")
    -   [Schedule(methodCall,enqueueOn)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Schedule-System-Linq-Expressions-Expression{System-Action},System-DateTimeOffset- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Schedule(System.Linq.Expressions.Expression{System.Action},System.DateTimeOffset)")
    -   [Schedule\`\`1(methodCall,delay)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Schedule``1-System-Linq-Expressions-Expression{System-Action{``0}},System-TimeSpan- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Schedule``1(System.Linq.Expressions.Expression{System.Action{``0}},System.TimeSpan)")
    -   [Schedule\`\`1(methodCall,enqueueOn)](#M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Schedule``1-System-Linq-Expressions-Expression{System-Action{``0}},System-DateTimeOffset- "RSM.HCD.CSharp.Core.Interfaces.Providers.Worker.IWorkerProvider.Schedule``1(System.Linq.Expressions.Expression{System.Action{``0}},System.DateTimeOffset)")
-   [JobStatus](#T-AndcultureCode-CSharp-Core-Enumerations-JobStatus "RSM.HCD.CSharp.Core.Enumerations.JobStatus")
-   [LocalConfigurationProvider](#T-AndcultureCode-CSharp-Core-Providers-Configuration-LocalConfigurationProvider "RSM.HCD.CSharp.Core.Providers.Configuration.LocalConfigurationProvider")
    -   [#ctor(basePath)](#M-AndcultureCode-CSharp-Core-Providers-Configuration-LocalConfigurationProvider-#ctor-System-String- "RSM.HCD.CSharp.Core.Providers.Configuration.LocalConfigurationProvider.#ctor(System.String)")
    -   [GetConfiguration()](#M-AndcultureCode-CSharp-Core-Providers-Configuration-LocalConfigurationProvider-GetConfiguration "RSM.HCD.CSharp.Core.Providers.Configuration.LocalConfigurationProvider.GetConfiguration")
-   [LocalizationUtils](#T-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils "RSM.HCD.CSharp.Core.Utilities.Localization.LocalizationUtils")
    -   [CultureInfos](#P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-CultureInfos "RSM.HCD.CSharp.Core.Utilities.Localization.LocalizationUtils.CultureInfos")
    -   [Cultures](#P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-Cultures "RSM.HCD.CSharp.Core.Utilities.Localization.LocalizationUtils.Cultures")
    -   [DefaultCulture](#P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-DefaultCulture "RSM.HCD.CSharp.Core.Utilities.Localization.LocalizationUtils.DefaultCulture")
    -   [DefaultCultureCode](#P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-DefaultCultureCode "RSM.HCD.CSharp.Core.Utilities.Localization.LocalizationUtils.DefaultCultureCode")
    -   [DefaultCultureInfo](#P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-DefaultCultureInfo "RSM.HCD.CSharp.Core.Utilities.Localization.LocalizationUtils.DefaultCultureInfo")
    -   [CultureByCode(cultureCode)](#M-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-CultureByCode-System-String- "RSM.HCD.CSharp.Core.Utilities.Localization.LocalizationUtils.CultureByCode(System.String)")
    -   [CultureCodes(delimiter)](#M-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-CultureCodes-System-String- "RSM.HCD.CSharp.Core.Utilities.Localization.LocalizationUtils.CultureCodes(System.String)")
    -   [CultureExists(cultureCode)](#M-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-CultureExists-System-String- "RSM.HCD.CSharp.Core.Utilities.Localization.LocalizationUtils.CultureExists(System.String)")
-   [Lockable](#T-AndcultureCode-CSharp-Core-Models-Lockable "RSM.HCD.CSharp.Core.Models.Lockable")
    -   [IsLocked](#P-AndcultureCode-CSharp-Core-Models-Lockable-IsLocked "RSM.HCD.CSharp.Core.Models.Lockable.IsLocked")
    -   [LockedById](#P-AndcultureCode-CSharp-Core-Models-Lockable-LockedById "RSM.HCD.CSharp.Core.Models.Lockable.LockedById")
    -   [LockedOn](#P-AndcultureCode-CSharp-Core-Models-Lockable-LockedOn "RSM.HCD.CSharp.Core.Models.Lockable.LockedOn")
    -   [LockedUntil](#P-AndcultureCode-CSharp-Core-Models-Lockable-LockedUntil "RSM.HCD.CSharp.Core.Models.Lockable.LockedUntil")
    -   [DetermineIfLocked()](#M-AndcultureCode-CSharp-Core-Models-Lockable-DetermineIfLocked "RSM.HCD.CSharp.Core.Models.Lockable.DetermineIfLocked")
-   [LogicalOperator](#T-AndcultureCode-CSharp-Core-Enumerations-LogicalOperator "RSM.HCD.CSharp.Core.Enumerations.LogicalOperator")
-   [OAuthAccountConfiguration](#T-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration "RSM.HCD.CSharp.Business.Core.Models.Configuration.OAuthAccountConfiguration")
    -   [ClientId](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration-ClientId "RSM.HCD.CSharp.Business.Core.Models.Configuration.OAuthAccountConfiguration.ClientId")
    -   [ClientSecret](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration-ClientSecret "RSM.HCD.CSharp.Business.Core.Models.Configuration.OAuthAccountConfiguration.ClientSecret")
    -   [IsDisabled](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration-IsDisabled "RSM.HCD.CSharp.Business.Core.Models.Configuration.OAuthAccountConfiguration.IsDisabled")
    -   [IsEnabled](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration-IsEnabled "RSM.HCD.CSharp.Business.Core.Models.Configuration.OAuthAccountConfiguration.IsEnabled")
-   [ObjectExtensions](#T-AndcultureCode-CSharp-Core-Extensions-ObjectExtensions "RSM.HCD.CSharp.Core.Extensions.ObjectExtensions")
    -   [FromByteArray\`\`1()](#M-AndcultureCode-CSharp-Core-Extensions-ObjectExtensions-FromByteArray``1-System-Byte[]- "RSM.HCD.CSharp.Core.Extensions.ObjectExtensions.FromByteArray``1(System.Byte[])")
    -   [ToByteArray(obj)](#M-AndcultureCode-CSharp-Core-Extensions-ObjectExtensions-ToByteArray-System-Object- "RSM.HCD.CSharp.Core.Extensions.ObjectExtensions.ToByteArray(System.Object)")
-   [OrderedList\`2](#T-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2 "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2")
    -   [#ctor()](#M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-#ctor "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.#ctor")
    -   [#ctor(comparer)](#M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-#ctor-System-Collections-Generic-IComparer{`0}- "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.#ctor(System.Collections.Generic.IComparer{`0})")
    -   [Count](#P-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Count "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.Count")
    -   [IsReadOnly](#P-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-IsReadOnly "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.IsReadOnly")
    -   [Item](#P-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Item-`0- "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.Item(`0)")
    -   [Keys](#P-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Keys "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.Keys")
    -   [Add(key,value)](#M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Add-`0,`1- "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.Add(`0,`1)")
    -   [Clear()](#M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Clear "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.Clear")
    -   [ContainsKey(key)](#M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-ContainsKey-`0- "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.ContainsKey(`0)")
    -   [GetEnumerator()](#M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-GetEnumerator "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.GetEnumerator")
    -   [Remove(key,value)](#M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Remove-`0,`1- "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.Remove(`0,`1)")
    -   [TryGetValue(key,value)](#M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-TryGetValue-`0,System-Collections-Generic-ICollection{`1}@- "RSM.HCD.CSharp.Core.Models.Collections.OrderedList`2.TryGetValue(`0,System.Collections.Generic.ICollection{`1}@)")
-   [PagedResult\`1](#T-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1 "RSM.HCD.CSharp.Core.Models.Errors.PagedResult`1")
    -   [#ctor(rows,rowCount)](#M-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-#ctor-`0,System-Int64- "RSM.HCD.CSharp.Core.Models.Errors.PagedResult`1.#ctor(`0,System.Int64)")
    -   [#ctor(rows,rowCount,nextLinkParams)](#M-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-#ctor-`0,System-Int64,System-Collections-Generic-Dictionary{System-String,System-String}- "RSM.HCD.CSharp.Core.Models.Errors.PagedResult`1.#ctor(`0,System.Int64,System.Collections.Generic.Dictionary{System.String,System.String})")
    -   [ErrorCount](#P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-ErrorCount "RSM.HCD.CSharp.Core.Models.Errors.PagedResult`1.ErrorCount")
    -   [Errors](#P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-Errors "RSM.HCD.CSharp.Core.Models.Errors.PagedResult`1.Errors")
    -   [HasErrors](#P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-HasErrors "RSM.HCD.CSharp.Core.Models.Errors.PagedResult`1.HasErrors")
    -   [NextLinkParams](#P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-NextLinkParams "RSM.HCD.CSharp.Core.Models.Errors.PagedResult`1.NextLinkParams")
    -   [ResultObject](#P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-ResultObject "RSM.HCD.CSharp.Core.Models.Errors.PagedResult`1.ResultObject")
    -   [RowCount](#P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-RowCount "RSM.HCD.CSharp.Core.Models.Errors.PagedResult`1.RowCount")
-   [Provider](#T-AndcultureCode-CSharp-Core-Providers-Provider "RSM.HCD.CSharp.Core.Providers.Provider")
    -   [Implemented](#P-AndcultureCode-CSharp-Core-Providers-Provider-Implemented "RSM.HCD.CSharp.Core.Providers.Provider.Implemented")
    -   [Name](#P-AndcultureCode-CSharp-Core-Providers-Provider-Name "RSM.HCD.CSharp.Core.Providers.Provider.Name")
-   [Queue](#T-AndcultureCode-CSharp-Core-Constants-Queue "RSM.HCD.CSharp.Core.Constants.Queue")
    -   [ALL](#F-AndcultureCode-CSharp-Core-Constants-Queue-ALL "RSM.HCD.CSharp.Core.Constants.Queue.ALL")
    -   [DEFAULT](#F-AndcultureCode-CSharp-Core-Constants-Queue-DEFAULT "RSM.HCD.CSharp.Core.Constants.Queue.DEFAULT")
-   [Recurrence](#T-AndcultureCode-CSharp-Core-Enumerations-Recurrence "RSM.HCD.CSharp.Core.Enumerations.Recurrence")
-   [RecurringOption](#T-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption")
    -   [Day](#P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Day "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption.Day")
    -   [DayOfWeek](#P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-DayOfWeek "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption.DayOfWeek")
    -   [Hour](#P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Hour "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption.Hour")
    -   [Minute](#P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Minute "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption.Minute")
    -   [Month](#P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Month "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption.Month")
    -   [Recurrence](#P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Recurrence "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption.Recurrence")
-   [ResourceVerb](#T-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb "RSM.HCD.CSharp.Core.Models.Security.ResourceVerb")
    -   [#ctor(resource,verb)](#M-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-#ctor-System-String,System-String- "RSM.HCD.CSharp.Core.Models.Security.ResourceVerb.#ctor(System.String,System.String)")
    -   [#ctor(resourceVerb)](#M-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-#ctor-System-String- "RSM.HCD.CSharp.Core.Models.Security.ResourceVerb.#ctor(System.String)")
    -   [Resource](#P-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-Resource "RSM.HCD.CSharp.Core.Models.Security.ResourceVerb.Resource")
    -   [Verb](#P-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-Verb "RSM.HCD.CSharp.Core.Models.Security.ResourceVerb.Verb")
    -   [ToString()](#M-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-ToString "RSM.HCD.CSharp.Core.Models.Security.ResourceVerb.ToString")
-   [ResourceVerbExtensions](#T-AndcultureCode-CSharp-Core-Extensions-ResourceVerbExtensions "RSM.HCD.CSharp.Core.Extensions.ResourceVerbExtensions")
    -   [ToResourceVerb(resourceVerbString)](#M-AndcultureCode-CSharp-Core-Extensions-ResourceVerbExtensions-ToResourceVerb-System-String- "RSM.HCD.CSharp.Core.Extensions.ResourceVerbExtensions.ToResourceVerb(System.String)")
    -   [ToResourceVerbs(resourceVerbStrings)](#M-AndcultureCode-CSharp-Core-Extensions-ResourceVerbExtensions-ToResourceVerbs-System-Collections-Generic-IEnumerable{System-String}- "RSM.HCD.CSharp.Core.Extensions.ResourceVerbExtensions.ToResourceVerbs(System.Collections.Generic.IEnumerable{System.String})")
-   [Result\`1](#T-AndcultureCode-CSharp-Core-Models-Errors-Result`1 "RSM.HCD.CSharp.Core.Models.Errors.Result`1")
    -   [#ctor()](#M-AndcultureCode-CSharp-Core-Models-Errors-Result`1-#ctor "RSM.HCD.CSharp.Core.Models.Errors.Result`1.#ctor")
    -   [#ctor(errorMessage)](#M-AndcultureCode-CSharp-Core-Models-Errors-Result`1-#ctor-System-String- "RSM.HCD.CSharp.Core.Models.Errors.Result`1.#ctor(System.String)")
    -   [#ctor(errorKey,errorMessage)](#M-AndcultureCode-CSharp-Core-Models-Errors-Result`1-#ctor-System-String,System-String- "RSM.HCD.CSharp.Core.Models.Errors.Result`1.#ctor(System.String,System.String)")
    -   [#ctor(resultObject)](#M-AndcultureCode-CSharp-Core-Models-Errors-Result`1-#ctor-`0- "RSM.HCD.CSharp.Core.Models.Errors.Result`1.#ctor(`0)")
    -   [ErrorCount](#P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-ErrorCount "RSM.HCD.CSharp.Core.Models.Errors.Result`1.ErrorCount")
    -   [Errors](#P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-Errors "RSM.HCD.CSharp.Core.Models.Errors.Result`1.Errors")
    -   [HasErrors](#P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-HasErrors "RSM.HCD.CSharp.Core.Models.Errors.Result`1.HasErrors")
    -   [NextLinkParams](#P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-NextLinkParams "RSM.HCD.CSharp.Core.Models.Errors.Result`1.NextLinkParams")
    -   [ResultObject](#P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-ResultObject "RSM.HCD.CSharp.Core.Models.Errors.Result`1.ResultObject")
-   [ReverseComparer\`1](#T-AndcultureCode-CSharp-Core-Models-Collections-ReverseComparer`1 "RSM.HCD.CSharp.Core.Models.Collections.ReverseComparer`1")
    -   [#ctor()](#M-AndcultureCode-CSharp-Core-Models-Collections-ReverseComparer`1-#ctor "RSM.HCD.CSharp.Core.Models.Collections.ReverseComparer`1.#ctor")
    -   [#ctor(comparer)](#M-AndcultureCode-CSharp-Core-Models-Collections-ReverseComparer`1-#ctor-System-Collections-Generic-IComparer{`0}- "RSM.HCD.CSharp.Core.Models.Collections.ReverseComparer`1.#ctor(System.Collections.Generic.IComparer{`0})")
    -   [Compare(x,y)](#M-AndcultureCode-CSharp-Core-Models-Collections-ReverseComparer`1-Compare-`0,`0- "RSM.HCD.CSharp.Core.Models.Collections.ReverseComparer`1.Compare(`0,`0)")
-   [Rfc4646LanguageCodes](#T-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes")
    -   [AF_ZA](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AF_ZA "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AF_ZA")
    -   [AR_AE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_AE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_AE")
    -   [AR_BH](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_BH "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_BH")
    -   [AR_DZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_DZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_DZ")
    -   [AR_EG](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_EG "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_EG")
    -   [AR_IQ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_IQ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_IQ")
    -   [AR_JO](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_JO "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_JO")
    -   [AR_KW](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_KW "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_KW")
    -   [AR_LB](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_LB "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_LB")
    -   [AR_LY](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_LY "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_LY")
    -   [AR_MA](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_MA "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_MA")
    -   [AR_OM](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_OM "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_OM")
    -   [AR_QA](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_QA "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_QA")
    -   [AR_SA](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_SA "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_SA")
    -   [AR_SY](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_SY "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_SY")
    -   [AR_TN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_TN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_TN")
    -   [AR_YE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_YE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.AR_YE")
    -   [BE_BY](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-BE_BY "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.BE_BY")
    -   [BG_BG](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-BG_BG "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.BG_BG")
    -   [CA_ES](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CA_ES "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.CA_ES")
    -   [CS_CZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CS_CZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.CS_CZ")
    -   [CY_AZ_AZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CY_AZ_AZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.CY_AZ_AZ")
    -   [CY_SR_SP](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CY_SR_SP "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.CY_SR_SP")
    -   [CY_UZ_UZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CY_UZ_UZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.CY_UZ_UZ")
    -   [DA_DK](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DA_DK "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.DA_DK")
    -   [DE_AT](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_AT "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.DE_AT")
    -   [DE_CH](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_CH "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.DE_CH")
    -   [DE_DE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_DE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.DE_DE")
    -   [DE_LI](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_LI "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.DE_LI")
    -   [DE_LU](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_LU "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.DE_LU")
    -   [DIV_MV](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DIV_MV "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.DIV_MV")
    -   [EL_GR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EL_GR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EL_GR")
    -   [EN_AU](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_AU "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_AU")
    -   [EN_BZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_BZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_BZ")
    -   [EN_CA](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_CA "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_CA")
    -   [EN_CB](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_CB "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_CB")
    -   [EN_GB](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_GB "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_GB")
    -   [EN_IE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_IE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_IE")
    -   [EN_JM](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_JM "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_JM")
    -   [EN_NZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_NZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_NZ")
    -   [EN_PH](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_PH "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_PH")
    -   [EN_TT](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_TT "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_TT")
    -   [EN_US](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_US "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_US")
    -   [EN_ZA](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_ZA "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_ZA")
    -   [EN_ZW](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_ZW "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EN_ZW")
    -   [ES_AR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_AR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_AR")
    -   [ES_BO](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_BO "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_BO")
    -   [ES_CL](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_CL "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_CL")
    -   [ES_CO](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_CO "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_CO")
    -   [ES_CR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_CR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_CR")
    -   [ES_DO](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_DO "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_DO")
    -   [ES_EC](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_EC "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_EC")
    -   [ES_ES](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_ES "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_ES")
    -   [ES_GT](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_GT "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_GT")
    -   [ES_HN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_HN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_HN")
    -   [ES_MX](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_MX "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_MX")
    -   [ES_NI](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_NI "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_NI")
    -   [ES_PA](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_PA "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_PA")
    -   [ES_PE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_PE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_PE")
    -   [ES_PR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_PR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_PR")
    -   [ES_PY](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_PY "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_PY")
    -   [ES_SV](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_SV "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_SV")
    -   [ES_UY](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_UY "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_UY")
    -   [ES_VE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_VE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ES_VE")
    -   [ET_EE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ET_EE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ET_EE")
    -   [EU_ES](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EU_ES "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.EU_ES")
    -   [FA_IR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FA_IR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.FA_IR")
    -   [FI_FI](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FI_FI "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.FI_FI")
    -   [FO_FO](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FO_FO "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.FO_FO")
    -   [FR_BE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_BE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.FR_BE")
    -   [FR_CA](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_CA "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.FR_CA")
    -   [FR_CH](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_CH "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.FR_CH")
    -   [FR_FR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_FR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.FR_FR")
    -   [FR_LU](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_LU "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.FR_LU")
    -   [FR_MC](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_MC "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.FR_MC")
    -   [GL_ES](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-GL_ES "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.GL_ES")
    -   [GU_IN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-GU_IN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.GU_IN")
    -   [HE_IL](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HE_IL "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.HE_IL")
    -   [HI_IN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HI_IN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.HI_IN")
    -   [HR_HR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HR_HR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.HR_HR")
    -   [HU_HU](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HU_HU "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.HU_HU")
    -   [HY_AM](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HY_AM "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.HY_AM")
    -   [ID_ID](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ID_ID "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ID_ID")
    -   [IS_IS](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-IS_IS "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.IS_IS")
    -   [IT_CH](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-IT_CH "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.IT_CH")
    -   [IT_IT](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-IT_IT "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.IT_IT")
    -   [JA_JP](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-JA_JP "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.JA_JP")
    -   [KA_GE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KA_GE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.KA_GE")
    -   [KK_KZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KK_KZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.KK_KZ")
    -   [KN_IN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KN_IN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.KN_IN")
    -   [KOK_IN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KOK_IN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.KOK_IN")
    -   [KO_KR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KO_KR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.KO_KR")
    -   [KY_KZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KY_KZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.KY_KZ")
    -   [LT_AZ_AZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LT_AZ_AZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.LT_AZ_AZ")
    -   [LT_LT](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LT_LT "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.LT_LT")
    -   [LT_SR_SP](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LT_SR_SP "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.LT_SR_SP")
    -   [LT_UZ_UZ](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LT_UZ_UZ "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.LT_UZ_UZ")
    -   [LV_LV](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LV_LV "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.LV_LV")
    -   [MK_MK](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MK_MK "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.MK_MK")
    -   [MN_MN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MN_MN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.MN_MN")
    -   [MR_IN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MR_IN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.MR_IN")
    -   [MS_BN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MS_BN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.MS_BN")
    -   [MS_MY](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MS_MY "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.MS_MY")
    -   [NB_NO](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-NB_NO "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.NB_NO")
    -   [NL_BE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-NL_BE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.NL_BE")
    -   [NL_NL](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-NL_NL "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.NL_NL")
    -   [NN_NO](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-NN_NO "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.NN_NO")
    -   [PA_IN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-PA_IN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.PA_IN")
    -   [PL_PL](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-PL_PL "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.PL_PL")
    -   [PT_BR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-PT_BR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.PT_BR")
    -   [PT_PT](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-PT_PT "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.PT_PT")
    -   [RO_RO](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-RO_RO "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.RO_RO")
    -   [RU_RU](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-RU_RU "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.RU_RU")
    -   [SA_IN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SA_IN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.SA_IN")
    -   [SK_SK](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SK_SK "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.SK_SK")
    -   [SL_SI](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SL_SI "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.SL_SI")
    -   [SQ_AL](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SQ_AL "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.SQ_AL")
    -   [SV_FI](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SV_FI "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.SV_FI")
    -   [SV_SE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SV_SE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.SV_SE")
    -   [SW_KE](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SW_KE "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.SW_KE")
    -   [SYR_SY](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SYR_SY "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.SYR_SY")
    -   [TA_IN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TA_IN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.TA_IN")
    -   [TE_IN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TE_IN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.TE_IN")
    -   [TH_TH](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TH_TH "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.TH_TH")
    -   [TR_TR](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TR_TR "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.TR_TR")
    -   [TT_RU](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TT_RU "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.TT_RU")
    -   [UK_UA](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-UK_UA "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.UK_UA")
    -   [UR_PK](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-UR_PK "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.UR_PK")
    -   [VI_VN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-VI_VN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.VI_VN")
    -   [ZH_CHS](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_CHS "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ZH_CHS")
    -   [ZH_CHT](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_CHT "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ZH_CHT")
    -   [ZH_CN](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_CN "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ZH_CN")
    -   [ZH_HK](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_HK "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ZH_HK")
    -   [ZH_MO](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_MO "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ZH_MO")
    -   [ZH_SG](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_SG "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ZH_SG")
    -   [ZH_TW](#F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_TW "RSM.HCD.CSharp.Core.Constants.Rfc4646LanguageCodes.ZH_TW")
-   [SeedsBase\`1](#T-AndcultureCode-CSharp-Core-SeedsBase`1 "RSM.HCD.CSharp.Core.SeedsBase`1")
    -   [#ctor(serviceProvider,isDevelopment)](#M-AndcultureCode-CSharp-Core-SeedsBase`1-#ctor-System-IServiceProvider,System-Boolean- "RSM.HCD.CSharp.Core.SeedsBase`1.#ctor(System.IServiceProvider,System.Boolean)")
    -   [Context](#P-AndcultureCode-CSharp-Core-SeedsBase`1-Context "RSM.HCD.CSharp.Core.SeedsBase`1.Context")
    -   [IsDevelopment](#P-AndcultureCode-CSharp-Core-SeedsBase`1-IsDevelopment "RSM.HCD.CSharp.Core.SeedsBase`1.IsDevelopment")
    -   [Logger](#P-AndcultureCode-CSharp-Core-SeedsBase`1-Logger "RSM.HCD.CSharp.Core.SeedsBase`1.Logger")
    -   [ServiceProvider](#P-AndcultureCode-CSharp-Core-SeedsBase`1-ServiceProvider "RSM.HCD.CSharp.Core.SeedsBase`1.ServiceProvider")
    -   [Create()](#M-AndcultureCode-CSharp-Core-SeedsBase`1-Create "RSM.HCD.CSharp.Core.SeedsBase`1.Create")
    -   [CreateBase()](#M-AndcultureCode-CSharp-Core-SeedsBase`1-CreateBase "RSM.HCD.CSharp.Core.SeedsBase`1.CreateBase")
    -   [CreateDevelopment()](#M-AndcultureCode-CSharp-Core-SeedsBase`1-CreateDevelopment "RSM.HCD.CSharp.Core.SeedsBase`1.CreateDevelopment")
    -   [GetDep\`\`1()](#M-AndcultureCode-CSharp-Core-SeedsBase`1-GetDep``1 "RSM.HCD.CSharp.Core.SeedsBase`1.GetDep``1")
    -   [Log(seedName,message)](#M-AndcultureCode-CSharp-Core-SeedsBase`1-Log-System-String,System-String- "RSM.HCD.CSharp.Core.SeedsBase`1.Log(System.String,System.String)")
    -   [LogEnd(seedName)](#M-AndcultureCode-CSharp-Core-SeedsBase`1-LogEnd-System-String- "RSM.HCD.CSharp.Core.SeedsBase`1.LogEnd(System.String)")
    -   [LogEnd\`\`1()](#M-AndcultureCode-CSharp-Core-SeedsBase`1-LogEnd``1 "RSM.HCD.CSharp.Core.SeedsBase`1.LogEnd``1")
    -   [LogStart(seedName)](#M-AndcultureCode-CSharp-Core-SeedsBase`1-LogStart-System-String- "RSM.HCD.CSharp.Core.SeedsBase`1.LogStart(System.String)")
    -   [LogStart\`\`1()](#M-AndcultureCode-CSharp-Core-SeedsBase`1-LogStart``1 "RSM.HCD.CSharp.Core.SeedsBase`1.LogStart``1")
    -   [Log\`\`1(message)](#M-AndcultureCode-CSharp-Core-SeedsBase`1-Log``1-System-String- "RSM.HCD.CSharp.Core.SeedsBase`1.Log``1(System.String)")
-   [SeedsConfiguration](#T-AndcultureCode-CSharp-Business-Core-Models-Configuration-SeedsConfiguration "RSM.HCD.CSharp.Business.Core.Models.Configuration.SeedsConfiguration")
    -   [DefaultUserPassword](#P-AndcultureCode-CSharp-Business-Core-Models-Configuration-SeedsConfiguration-DefaultUserPassword "RSM.HCD.CSharp.Business.Core.Models.Configuration.SeedsConfiguration.DefaultUserPassword")
-   [SpanishSpain](#T-AndcultureCode-CSharp-Core-Cultures-SpanishSpain "RSM.HCD.CSharp.Core.Cultures.SpanishSpain")
    -   [Code](#P-AndcultureCode-CSharp-Core-Cultures-SpanishSpain-Code "RSM.HCD.CSharp.Core.Cultures.SpanishSpain.Code")
-   [StringExtensions](#T-AndcultureCode-CSharp-Core-Extensions-StringExtensions "RSM.HCD.CSharp.Core.Extensions.StringExtensions")
    -   [LoadTranslations()](#M-AndcultureCode-CSharp-Core-Extensions-StringExtensions-LoadTranslations-System-String,System-String,Newtonsoft-Json-JsonSerializerSettings- "RSM.HCD.CSharp.Core.Extensions.StringExtensions.LoadTranslations(System.String,System.String,Newtonsoft.Json.JsonSerializerSettings)")
-   [UriUtils](#T-AndcultureCode-CSharp-Core-Utilities-Network-UriUtils "RSM.HCD.CSharp.Core.Utilities.Network.UriUtils")
    -   [IsInvalidHttpUrl()](#M-AndcultureCode-CSharp-Core-Utilities-Network-UriUtils-IsInvalidHttpUrl-System-String- "RSM.HCD.CSharp.Core.Utilities.Network.UriUtils.IsInvalidHttpUrl(System.String)")
    -   [IsValidHttpUrl()](#M-AndcultureCode-CSharp-Core-Utilities-Network-UriUtils-IsValidHttpUrl-System-String- "RSM.HCD.CSharp.Core.Utilities.Network.UriUtils.IsValidHttpUrl(System.String)")
-   [UserMetadataNames](#T-AndcultureCode-CSharp-Core-Constants-UserMetadataNames "RSM.HCD.CSharp.Core.Constants.UserMetadataNames")
    -   [FACEBOOK](#F-AndcultureCode-CSharp-Core-Constants-UserMetadataNames-FACEBOOK "RSM.HCD.CSharp.Core.Constants.UserMetadataNames.FACEBOOK")
    -   [GOOGLE](#F-AndcultureCode-CSharp-Core-Constants-UserMetadataNames-GOOGLE "RSM.HCD.CSharp.Core.Constants.UserMetadataNames.GOOGLE")
    -   [MICROSOFT](#F-AndcultureCode-CSharp-Core-Constants-UserMetadataNames-MICROSOFT "RSM.HCD.CSharp.Core.Constants.UserMetadataNames.MICROSOFT")
    -   [TWITTER](#F-AndcultureCode-CSharp-Core-Constants-UserMetadataNames-TWITTER "RSM.HCD.CSharp.Core.Constants.UserMetadataNames.TWITTER")
-   [UserMetadataTypes](#T-AndcultureCode-CSharp-Core-Constants-UserMetadataTypes "RSM.HCD.CSharp.Core.Constants.UserMetadataTypes")
    -   [ExternalUserId](#F-AndcultureCode-CSharp-Core-Constants-UserMetadataTypes-ExternalUserId "RSM.HCD.CSharp.Core.Constants.UserMetadataTypes.ExternalUserId")
-   [WorkerProvider](#T-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider")
    -   [Delete(id)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Delete-System-String- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Delete(System.String)")
    -   [DeletedCount()](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-DeletedCount "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.DeletedCount")
    -   [Enqueue(methodCall)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Enqueue-System-Linq-Expressions-Expression{System-Action}- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Enqueue(System.Linq.Expressions.Expression{System.Action})")
    -   [Enqueue\`\`1(methodCall)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Enqueue``1-System-Linq-Expressions-Expression{System-Action{``0}}- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Enqueue``1(System.Linq.Expressions.Expression{System.Action{``0}})")
    -   [EnqueuedCount(queue)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-EnqueuedCount-System-String- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.EnqueuedCount(System.String)")
    -   [Recur(id,methodCall,recurringOptions)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Recur-System-String,System-Linq-Expressions-Expression{System-Action},AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Recur(System.String,System.Linq.Expressions.Expression{System.Action},RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption)")
    -   [Recur\`\`1(id,methodCall,chronExpression)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Recur``1-System-String,System-Linq-Expressions-Expression{System-Action{``0}},System-String- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Recur``1(System.String,System.Linq.Expressions.Expression{System.Action{``0}},System.String)")
    -   [Recur\`\`1(id,methodCall,recurringOptions)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Recur``1-System-String,System-Linq-Expressions-Expression{System-Action{``0}},AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Recur``1(System.String,System.Linq.Expressions.Expression{System.Action{``0}},RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption)")
    -   [RecurringCount()](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-RecurringCount "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.RecurringCount")
    -   [RemoveRecurrence(id)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-RemoveRecurrence-System-String- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.RemoveRecurrence(System.String)")
    -   [Schedule(methodCall,enqueueOn)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Schedule-System-Linq-Expressions-Expression{System-Action},System-DateTimeOffset- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Schedule(System.Linq.Expressions.Expression{System.Action},System.DateTimeOffset)")
    -   [Schedule(methodCall,delay)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Schedule-System-Linq-Expressions-Expression{System-Action},System-TimeSpan- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Schedule(System.Linq.Expressions.Expression{System.Action},System.TimeSpan)")
    -   [Schedule\`\`1(methodCall,enqueueOn)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Schedule``1-System-Linq-Expressions-Expression{System-Action{``0}},System-DateTimeOffset- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Schedule``1(System.Linq.Expressions.Expression{System.Action{``0}},System.DateTimeOffset)")
    -   [Schedule\`\`1(methodCall,delay)](#M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Schedule``1-System-Linq-Expressions-Expression{System-Action{``0}},System-TimeSpan- "RSM.HCD.CSharp.Core.Providers.Worker.WorkerProvider.Schedule``1(System.Linq.Expressions.Expression{System.Action{``0}},System.TimeSpan)")

<a name='T-AndcultureCode-CSharp-Core-Models-Security-AccessRule'></a>

## AccessRule `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Security

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='M-AndcultureCode-CSharp-Core-Models-Security-AccessRule-#ctor-System-String,System-String,System-String-'></a>

### #ctor(resource,verb,subject) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name     | Type                                                                                                                    | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| resource | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| verb     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| subject  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='P-AndcultureCode-CSharp-Core-Models-Security-AccessRule-Permission'></a>

### Permission `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Security-AccessRule-Resource'></a>

### Resource `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Security-AccessRule-Subject'></a>

### Subject `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Security-AccessRule-Verb'></a>

### Verb `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='T-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl'></a>

## Acl `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Entities.Acls

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl-Permission'></a>

### Permission `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl-Resource'></a>

### Resource `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl-Subject'></a>

### Subject `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Acls-Acl-Verb'></a>

### Verb `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='T-AndcultureCode-CSharp-Core-Models-Security-Allow'></a>

## Allow `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Security

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='M-AndcultureCode-CSharp-Core-Models-Security-Allow-#ctor-System-String,System-String,System-String-'></a>

### #ctor(resource,verb,subject) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name     | Type                                                                                                                    | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| resource | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| verb     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| subject  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='P-AndcultureCode-CSharp-Core-Models-Security-Allow-Permission'></a>

### Permission `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='T-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider'></a>

## AmazonEBConfigurationProvider `type`

##### Namespace

RSM.HCD.CSharp.Core.Utilities.Configuration

##### Summary

Adds support to read environment variables from an Amazon Elastic Beanstalk EC2 instance

At this time AWS stores these environment variables in its own proprietary configuration
that we are forced to read and pipe to the application.

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-#ctor'></a>

### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AmazonEBConfigurationProvider](#T-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider") class with default values for [ConfigurationFilePath](#P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-ConfigurationFilePath "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.ConfigurationFilePath") and [StdoutEnabled](#P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-StdoutEnabled "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.StdoutEnabled")

##### Parameters

This constructor has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-#ctor-System-Boolean,System-String-'></a>

### #ctor(stdoutEnabled,configurationFilePath) `constructor`

##### Summary

Initializes a new instance of the [AmazonEBConfigurationProvider](#T-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider") class with optional values for [ConfigurationFilePath](#P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-ConfigurationFilePath "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.ConfigurationFilePath") and [StdoutEnabled](#P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-StdoutEnabled "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.StdoutEnabled")

##### Parameters

| Name                  | Type                                                                                                                       | Description                                                                                                                                                                                                                                                                                                      |
| --------------------- | -------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| stdoutEnabled         | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean") | Enables logging to standard output                                                                                                                                                                                                                                                                               |
| configurationFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")    | Path to configuration file, if not provided the value of [CONFIGURATION_FILE_PATH](#F-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-CONFIGURATION_FILE_PATH "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.CONFIGURATION_FILE_PATH") will be used |

<a name='F-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-CONFIGURATION_FILE_PATH'></a>

### CONFIGURATION_FILE_PATH `constants`

##### Summary

Absolute path to the AWS Elastic Beanstalk windows instance configuration file

<a name='P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-CachedConfiguration'></a>

### CachedConfiguration `property`

##### Summary

Must be static to cache initially loaded configuration across multiple requests

<a name='P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-ConfigurationFilePath'></a>

### ConfigurationFilePath `property`

##### Summary

Path for the AWS Elastic Beanstalk configuration file

<a name='P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-StdoutEnabled'></a>

### StdoutEnabled `property`

##### Summary

Determines if logging to standard output should be enabled

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-Get-System-String-'></a>

### Get(key) `method`

##### Summary

Gets the value of an environment variable by the given `key`

##### Returns

The environment variable or `null` if the key isn't present

##### Parameters

| Name | Type                                                                                                                    | Description                                   |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | --------------------------------------------- |
| key  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | The string identifying the requested variable |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-Has-System-String-'></a>

### Has(key) `method`

##### Summary

Checks if an environment variable by the given `key` is present in the configuration

##### Returns

`true` if the variable exists `false` otherwise

##### Parameters

| Name | Type                                                                                                                    | Description                                   |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | --------------------------------------------- |
| key  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | The string identifying the requested variable |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-Load'></a>

### Load() `method`

##### Summary

Load the configuration into the inherited 'Data' dictionary for use by ConfigurationRoot/Builder

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-Read'></a>

### Read() `method`

##### Summary

Reads the configuration from the [ConfigurationFilePath](#P-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-ConfigurationFilePath "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider.ConfigurationFilePath") and returns it as an IDictionary

##### Returns

A dictionary of key/values for all the environment variables in the configuration

##### Parameters

This method has no parameters.

##### Remarks

If the configuration file doesn't exist it returns an empty dictionary

The return value might be cached

<a name='T-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationSource'></a>

## AmazonEBConfigurationSource `type`

##### Namespace

RSM.HCD.CSharp.Core.Utilities.Configuration

##### Summary

Class used to create a [IConfigurationProvider](#T-Microsoft-Extensions-Configuration-IConfigurationProvider "Microsoft.Extensions.Configuration.IConfigurationProvider") that reads Amazon Elastic Beanstalk instance environment variables

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationSource-Build-Microsoft-Extensions-Configuration-IConfigurationBuilder-'></a>

### Build(builder) `method`

##### Summary

Builds a [IConfigurationProvider](#T-Microsoft-Extensions-Configuration-IConfigurationProvider "Microsoft.Extensions.Configuration.IConfigurationProvider") that reads Amazon Elastic Beanstalk instance environment variables

##### Returns

A new [AmazonEBConfigurationProvider](#T-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider") with default values

##### Parameters

| Name    | Type                                                                                                                                                                               | Description |
| ------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| builder | [Microsoft.Extensions.Configuration.IConfigurationBuilder](#T-Microsoft-Extensions-Configuration-IConfigurationBuilder "Microsoft.Extensions.Configuration.IConfigurationBuilder") |             |

<a name='T-AndcultureCode-CSharp-Core-Utilities-Hosting-AndcultureCodeWebHost'></a>

## AndcultureCodeWebHost `type`

##### Namespace

RSM.HCD.CSharp.Core.Utilities.Hosting

##### Summary

Static class related to our custom [WebHost](#T-Microsoft-AspNetCore-WebHost "Microsoft.AspNetCore.WebHost") builder pattern

<a name='M-AndcultureCode-CSharp-Core-Utilities-Hosting-AndcultureCodeWebHost-Preload-System-String[]-'></a>

### Preload() `method`

##### Summary

Entry point to our custom WebHost builder pattern.
From here extensions methods can but hung off of IAndcultureCodeWebHostBuilder

##### Returns

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder'></a>

## AndcultureCodeWebHostBuilder `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Hosting

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='M-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder-#ctor'></a>

### #ctor() `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

This constructor has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder-#ctor-System-String[]-'></a>

### #ctor(args) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name | Type                                                                                                                          | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------------------- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] "System.String[]") |             |

<a name='P-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder-Args'></a>

### Args `property`

##### Summary

The command line args to dotnet process. Ultimately piped to AspNetCore WebHost.

<a name='M-AndcultureCode-CSharp-Core-Models-Hosting-AndcultureCodeWebHostBuilder-CreateDefaultBuilder'></a>

### CreateDefaultBuilder() `method`

##### Summary

Simple wrapper around AspNetCore WebHost.CreateDefaultBuilder
to support our own extensibility model

##### Returns

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes'></a>

## ApiClaimTypes `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Commonly used Claim types for APIs

<a name='F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-IS_SUPER_ADMIN'></a>

### IS_SUPER_ADMIN `constants`

##### Summary

Is the current user elevated to super admin

<a name='F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-ROLE_ID'></a>

### ROLE_ID `constants`

##### Summary

Active Role Id

<a name='F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-ROLE_IDS'></a>

### ROLE_IDS `constants`

##### Summary

Available Role Ids

<a name='F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-ROLE_TYPE'></a>

### ROLE_TYPE `constants`

##### Summary

Active Role Type

<a name='F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-USER_ID'></a>

### USER_ID `constants`

##### Summary

Current User Id

<a name='F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-USER_LOGIN_ID'></a>

### USER_LOGIN_ID `constants`

##### Summary

Current User Login Id

<a name='T-AndcultureCode-CSharp-Core-Constants-ApplicationConstants'></a>

## ApplicationConstants `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Common application constants

<a name='F-AndcultureCode-CSharp-Core-Constants-ApplicationConstants-API_DATABASE_CONFIGURATION_KEY'></a>

### API_DATABASE_CONFIGURATION_KEY `constants`

##### Summary

Key name used to identify the API web application's primary
database in the 'ConnectionStrings' section

<a name='T-AndcultureCode-CSharp-Core-Models-Auditable'></a>

## Auditable `type`

##### Namespace

RSM.HCD.CSharp.Core.Models

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Auditable-CreatedById'></a>

### CreatedById `property`

##### Summary

The identifier of the user who created the record

<a name='P-AndcultureCode-CSharp-Core-Models-Auditable-CreatedOn'></a>

### CreatedOn `property`

##### Summary

The date and time of the record creation

<a name='P-AndcultureCode-CSharp-Core-Models-Auditable-DeletedById'></a>

### DeletedById `property`

##### Summary

The identifier of the user who performed the Delete

<a name='P-AndcultureCode-CSharp-Core-Models-Auditable-DeletedOn'></a>

### DeletedOn `property`

##### Summary

The date and time of the record deletion

<a name='P-AndcultureCode-CSharp-Core-Models-Auditable-UpdatedById'></a>

### UpdatedById `property`

##### Summary

The identifier of the user who performed the Update

<a name='P-AndcultureCode-CSharp-Core-Models-Auditable-UpdatedOn'></a>

### UpdatedOn `property`

##### Summary

The date and time of the record update

<a name='T-AndcultureCode-CSharp-Core-Models-Configuration-BasicAuthenticationConfiguration'></a>

## BasicAuthenticationConfiguration `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Configuration

##### Summary

Configuration properties available when setting up Basic HTTP authentication

<a name='P-AndcultureCode-CSharp-Core-Models-Configuration-BasicAuthenticationConfiguration-IsEnabled'></a>

### IsEnabled `property`

##### Summary

Is basic auth enabled for this environment?

<a name='P-AndcultureCode-CSharp-Core-Models-Configuration-BasicAuthenticationConfiguration-Password'></a>

### Password `property`

##### Summary

Password for users to use when authenticating

<a name='P-AndcultureCode-CSharp-Core-Models-Configuration-BasicAuthenticationConfiguration-UserName'></a>

### UserName `property`

##### Summary

Username for users to use when authenticating

<a name='T-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys'></a>

## CacheKeys `type`

##### Namespace

RSM.HCD.CSharp.Core.Utilities.Caching

##### Summary

Eased creation of cache keys

<a name='F-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-DEFAULT_DELIMITER'></a>

### DEFAULT_DELIMITER `constants`

##### Summary

Default delimiter used for creating cache keys

<a name='M-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-GetKey``1-System-Int64,System-Collections-Generic-List{System-Linq-Expressions-Expression{System-Func{``0,System-Object}}}-'></a>

### GetKey\`\`1(id,includeProperties) `method`

##### Summary

Construct standardized cache keys for entities with optional include properties

##### Parameters

| Name              | Type                                                                                                                                                                                                                                                                                                                    | Description |
| ----------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| id                | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                                                    |             |
| includeProperties | [System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{\`\`0,System.Object}}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List "System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{``0,System.Object}}}") |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-GetKey``1-System-Int64,System-String,System-Collections-Generic-List{System-Linq-Expressions-Expression{System-Func{``0,System-Object}}}-'></a>

### GetKey\`\`1(id,delimiter,includeProperties) `method`

##### Summary

Construct standardized cache keys for entities with optional include properties

##### Parameters

| Name              | Type                                                                                                                                                                                                                                                                                                                    | Description |
| ----------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| id                | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                                                    |             |
| delimiter         | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                                                 |             |
| includeProperties | [System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{\`\`0,System.Object}}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List "System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{``0,System.Object}}}") |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-GetKey``2-System-Int64,System-Collections-Generic-List{System-Linq-Expressions-Expression{System-Func{``1,System-Object}}}-'></a>

### GetKey\`\`2(id,includeProperties) `method`

##### Summary

Construct standardized cache keys for entities with optional include properties

##### Parameters

| Name              | Type                                                                                                                                                                                                                                                                                                                    | Description |
| ----------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| id                | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                                                    |             |
| includeProperties | [System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{\`\`1,System.Object}}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List "System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{``1,System.Object}}}") |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Caching-CacheKeys-GetKey``2-System-Int64,System-String,System-Collections-Generic-List{System-Linq-Expressions-Expression{System-Func{``1,System-Object}}}-'></a>

### GetKey\`\`2(id,delimiter,includeProperties) `method`

##### Summary

Construct standardized cache keys for entities with optional include properties

##### Parameters

| Name              | Type                                                                                                                                                                                                                                                                                                                    | Description |
| ----------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| id                | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                                                    |             |
| delimiter         | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                                                 |             |
| includeProperties | [System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{\`\`1,System.Object}}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List "System.Collections.Generic.List{System.Linq.Expressions.Expression{System.Func{``1,System.Object}}}") |

<a name='T-AndcultureCode-CSharp-Core-Constants-CacheOptions'></a>

## CacheOptions `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Common cache configuration options

<a name='F-AndcultureCode-CSharp-Core-Constants-CacheOptions-DAY'></a>

### DAY `constants`

##### Summary

Sliding cache expiration of a day (24 hours)

<a name='M-AndcultureCode-CSharp-Core-Constants-CacheOptions-Minutes-System-Double-'></a>

### Minutes(minutes) `method`

##### Summary

Configure options for X minutes sliding scale expiration

##### Returns

##### Parameters

| Name    | Type                                                                                                                    | Description |
| ------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| minutes | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double "System.Double") |             |

<a name='T-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils'></a>

## ConfigurationUtils `type`

##### Namespace

RSM.HCD.CSharp.Core.Utilities.Configuration

##### Summary

Static utility class to aid in configuration

<a name='P-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-Builder'></a>

### Builder `property`

##### Summary

Returns current instance of configuration builder

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-GetConfiguration'></a>

### GetConfiguration() `method`

##### Summary

Retrieve current instance of IConfigurationRoot

##### Returns

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-GetConnectionString-System-String-'></a>

### GetConnectionString(name) `method`

##### Summary

Retrieve currently configured connection string

##### Returns

##### Parameters

| Name | Type                                                                                                                    | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-SetConfiguration-Microsoft-Extensions-Configuration-IConfigurationRoot-'></a>

### SetConfiguration(configuration) `method`

##### Summary

Assign new instance of IConfigurationRoot

##### Parameters

| Name          | Type                                                                                                                                                                      | Description |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot "Microsoft.Extensions.Configuration.IConfigurationRoot") |             |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Configuration-ConfigurationUtils-SetConnectionString-System-String-'></a>

### SetConnectionString(connectionString) `method`

##### Summary

Explicitly set connection string at runtime. When set at runtime, this superceeds
values from the loaded configurationRoot object.

##### Parameters

| Name             | Type                                                                                                                    | Description |
| ---------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| connectionString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='T-AndcultureCode-CSharp-Core-Models-Connection'></a>

## Connection `type`

##### Namespace

RSM.HCD.CSharp.Core.Models

##### Summary

Breaks out standard connection string params into easy to consume object

<a name='P-AndcultureCode-CSharp-Core-Models-Connection-AdditionalParameters'></a>

### AdditionalParameters `property`

##### Summary

Additional configuration details

<a name='P-AndcultureCode-CSharp-Core-Models-Connection-Database'></a>

### Database `property`

##### Summary

Database name

<a name='P-AndcultureCode-CSharp-Core-Models-Connection-Datasource'></a>

### Datasource `property`

##### Summary

Data host

<a name='P-AndcultureCode-CSharp-Core-Models-Connection-Password'></a>

### Password `property`

##### Summary

Hopefully a secure password

<a name='P-AndcultureCode-CSharp-Core-Models-Connection-UserId'></a>

### UserId `property`

##### Summary

User identifier for the connectiong

<a name='M-AndcultureCode-CSharp-Core-Models-Connection-ToString-System-String-'></a>

### ToString(delimiter) `method`

##### Summary

Return the data to the form from which it came, a semi-colon delimited connection string

##### Returns

##### Parameters

| Name      | Type                                                                                                                    | Description |
| --------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Connection-ValidParameter-System-String-'></a>

### ValidParameter(value) `method`

##### Summary

Determines if the supplied value is a valid param

##### Returns

##### Parameters

| Name  | Type                                                                                                                    | Description |
| ----- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='T-AndcultureCode-CSharp-Core-Constants-ContentTypes'></a>

## ContentTypes `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Constants class to hold the various 'Content-Type' headers which indicate the media type
of the resource.
See https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type

<a name='F-AndcultureCode-CSharp-Core-Constants-ContentTypes-CSS'></a>

### CSS `constants`

##### Summary

Cascading Style Sheets (CSS)

<a name='F-AndcultureCode-CSharp-Core-Constants-ContentTypes-HTML'></a>

### HTML `constants`

##### Summary

HyperText Markup Language (HTML)

<a name='F-AndcultureCode-CSharp-Core-Constants-ContentTypes-JAVASCRIPT'></a>

### JAVASCRIPT `constants`

##### Summary

JavaScript

<a name='F-AndcultureCode-CSharp-Core-Constants-ContentTypes-JSON'></a>

### JSON `constants`

##### Summary

JavaScript Object Notation (JSON)

<a name='F-AndcultureCode-CSharp-Core-Constants-ContentTypes-PDF'></a>

### PDF `constants`

##### Summary

Adobe Portable Document Format (PDF)

<a name='F-AndcultureCode-CSharp-Core-Constants-ContentTypes-XML'></a>

### XML `constants`

##### Summary

Extensible Markup Language (XML)

<a name='T-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration'></a>

## CookieAuthenticationConfiguration `type`

##### Namespace

RSM.HCD.CSharp.Business.Core.Models.Configuration

##### Summary

Cookie authentication settings

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-AccessDeniedPath'></a>

### AccessDeniedPath `property`

##### Summary

Where to redirect user when access is denied.
Only applies to traditional web view auth flows.

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-AuthenticationScheme'></a>

### AuthenticationScheme `property`

##### Summary

Authentication scheme identifier

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-CookieName'></a>

### CookieName `property`

##### Summary

Cookie identifier

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-IsEnabled'></a>

### IsEnabled `property`

##### Summary

Is cookie authentication currently enabled?

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-CookieAuthenticationConfiguration-LoginPath'></a>

### LoginPath `property`

##### Summary

Where to redirect the user when they are required to login.
Only applies to traditional web view auth flows.

<a name='T-AndcultureCode-CSharp-Core-Constants-CoreConfiguration'></a>

## CoreConfiguration `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Identifiers used for IConfigurationRoot configured sections and values

<a name='F-AndcultureCode-CSharp-Core-Constants-CoreConfiguration-SEEDS'></a>

### SEEDS `constants`

##### Summary

General data seeding section

<a name='T-AndcultureCode-CSharp-Core-Models-Localization-Culture'></a>

## Culture `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Localization

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Localization-Culture-Code'></a>

### Code `property`

##### Summary

RFC-4646 5-character Culture code (xx-XX)

<a name='P-AndcultureCode-CSharp-Core-Models-Localization-Culture-CultureTranslations'></a>

### CultureTranslations `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Exceptions

| Name                                                                                                                             | Description |
| -------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception "System.Exception") |             |

<a name='P-AndcultureCode-CSharp-Core-Models-Localization-Culture-IsDefault'></a>

### IsDefault `property`

##### Summary

Is this the default locale in the application? There can only be one

<a name='T-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation'></a>

## CultureTranslation `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Localization

##### Summary

Translation of a specific term/key for the related culture.

Keys are in the language of the default culture. (Hopefully the language of this code base :)

<a name='P-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation-CultureCode'></a>

### CultureCode `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation-FilePath'></a>

### FilePath `property`

##### Summary

Translation file from which this translation was loaded

<a name='P-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation-Key'></a>

### Key `property`

##### Summary

Unique key identifying the translation

<a name='P-AndcultureCode-CSharp-Core-Models-Localization-CultureTranslation-Value'></a>

### Value `property`

##### Summary

Translation of message for this culture

<a name='T-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration'></a>

## DataConfiguration `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Configuration

##### Summary

Commonly used string lengths for various types of data

<a name='F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-EXTRA_SHORT_STRING_LENGTH'></a>

### EXTRA_SHORT_STRING_LENGTH `constants`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-IP_ADDRESS_LENGTH'></a>

### IP_ADDRESS_LENGTH `constants`

##### Summary

Maximum storage length for IP address columns.
IPv4 is 15 characters and IPv6 is 39 characters

<a name='F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-LONG_DESCRIPTION_LENGTH'></a>

### LONG_DESCRIPTION_LENGTH `constants`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-SHORT_DESCRIPTION_LENGTH'></a>

### SHORT_DESCRIPTION_LENGTH `constants`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-SHORT_STRING_LENGTH'></a>

### SHORT_STRING_LENGTH `constants`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-SHORT_TITLE_LENGTH'></a>

### SHORT_TITLE_LENGTH `constants`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='F-AndcultureCode-CSharp-Core-Models-Configuration-DataConfiguration-URL_LENGTH'></a>

### URL_LENGTH `constants`

##### Summary

IE has a max of 2083

<a name='T-AndcultureCode-CSharp-Core-Models-Security-Deny'></a>

## Deny `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Security

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='M-AndcultureCode-CSharp-Core-Models-Security-Deny-#ctor-System-String,System-String,System-String-'></a>

### #ctor(resource,verb,subject) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name     | Type                                                                                                                    | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| resource | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| verb     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| subject  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='P-AndcultureCode-CSharp-Core-Models-Security-Deny-Permission'></a>

### Permission `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='T-AndcultureCode-CSharp-Core-Do`1'></a>

## Do\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core

##### Summary

TODO: Backfill tests https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/15

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Do`1-Finally-Microsoft-Extensions-Logging-ILogger,System-Action{AndcultureCode-CSharp-Core-Interfaces-IResult{`0}}-'></a>

### Finally(logger,workload) `method`

##### Summary

Extension of 'Finally' that will automatically log any thrown exceptions

##### Returns

##### Parameters

| Name     | Type                                                                                                                                                                                                             | Description                                         |
| -------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------- |
| logger   | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                                                                           | Logger to use when an unhandled exception is caught |
| workload | [System.Action{RSM.HCD.CSharp.Core.Interfaces.IResult{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action "System.Action{RSM.HCD.CSharp.Core.Interfaces.IResult{`0}}") |

<a name='M-AndcultureCode-CSharp-Core-Do`1-Then-System-Func{AndcultureCode-CSharp-Core-Interfaces-IResult{`0},`0},System-Boolean-'></a>

### Then(workload,skipIfErrors) `method`

##### Summary

Chainable method to perform additional pieces of work beyond an initial try

##### Parameters

| Name         | Type                                                                                                                                                                                                              | Description                                   |
| ------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------- |
| workload     | [System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{\`0},\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{`0},`0}") | Single unit of work to attempt                |
| skipIfErrors | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                        | Provided work will be ignored if errors exist |

<a name='M-AndcultureCode-CSharp-Core-Do`1-Try-Microsoft-Extensions-Logging-ILogger,System-Func{AndcultureCode-CSharp-Core-Interfaces-IResult{`0},`0}-'></a>

### Try(logger,workload) `method`

##### Summary

Extension of 'Try' that will automatically log any thrown exceptions

##### Returns

##### Parameters

| Name     | Type                                                                                                                                                                                                              | Description                                         |
| -------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------- |
| logger   | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                                                                            | Logger to use when an unhandled exception is caught |
| workload | [System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{\`0},\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{`0},`0}") |                                                     |

<a name='M-AndcultureCode-CSharp-Core-Do`1-Try-Microsoft-Extensions-Logging-ILogger,System-UInt32,System-Func{AndcultureCode-CSharp-Core-Interfaces-IResult{`0},`0}-'></a>

### Try(logger,workload,retry) `method`

##### Summary

Tries to run the given workload the indicated number of times

##### Returns

##### Parameters

| Name                 | Type                                                                                                                                                                                                              | Description                                             |
| -------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------- |
| logger               | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                                                                            | Logger used to log errors with                          |
| workload             | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 "System.UInt32")                                                                                           | Workload to be performed                                |
| retry                | [System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{\`0},\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{`0},`0}") | Number of retries that should be performed. If value is |
| zero, will not retry |

<a name='M-AndcultureCode-CSharp-Core-Do`1-TrySeed``1-AndcultureCode-CSharp-Core-SeedsBase{``0},System-Func{AndcultureCode-CSharp-Core-Interfaces-IResult{`0},`0},System-String-'></a>

### TrySeed\`\`1(seeds,workload,seedName) `method`

##### Summary

Extension of 'Try' that will automatically log before, during and after seeding logic

##### Returns

##### Parameters

| Name     | Type                                                                                                                                                                                                              | Description                                                                   |
| -------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| seeds    | [RSM.HCD.CSharp.Core.SeedsBase{\`\`0}](#T-AndcultureCode-CSharp-Core-SeedsBase{``0} "RSM.HCD.CSharp.Core.SeedsBase{``0}")                                                                                         | Logger to use when an unhandled exception is caught                           |
| workload | [System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{\`0},\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{RSM.HCD.CSharp.Core.Interfaces.IResult{`0},`0}") |                                                                               |
| seedName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                           | Manually supply name of seed. By default, the invoking function name is used. |

<a name='T-AndcultureCode-CSharp-Core-Providers-EmailProviderBase'></a>

## EmailProviderBase `type`

##### Namespace

RSM.HCD.CSharp.Core.Providers

##### Summary

Base abstract class to provide email provider functionality

<a name='M-AndcultureCode-CSharp-Core-Providers-EmailProviderBase-Send-MimeKit-MimeMessage-'></a>

### Send(message) `method`

##### Summary

Deliver a message now

##### Returns

##### Parameters

| Name    | Type                                                                | Description |
| ------- | ------------------------------------------------------------------- | ----------- |
| message | [MimeKit.MimeMessage](#T-MimeKit-MimeMessage "MimeKit.MimeMessage") |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-EmailProviderBase-SendLater-MimeKit-MimeMessage-'></a>

### SendLater(message) `method`

##### Summary

Deliver a message later (via background jobs likely)

##### Returns

##### Parameters

| Name    | Type                                                                | Description |
| ------- | ------------------------------------------------------------------- | ----------- |
| message | [MimeKit.MimeMessage](#T-MimeKit-MimeMessage "MimeKit.MimeMessage") |             |

<a name='T-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings'></a>

## EmailSettings `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Mail

##### Summary

Commonly used email settings

<a name='F-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-ERROR_MISSING_PROPERTY'></a>

### ERROR_MISSING_PROPERTY `constants`

##### Summary

Required property is not supplied

<a name='P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-CustomHeaders'></a>

### CustomHeaders `property`

##### Summary

Comma-separated list of custom X-Headers

<a name='P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-CustomHeadersAsDictionary'></a>

### CustomHeadersAsDictionary `property`

##### Summary

Transforms 'CustomHeaders' into a dictionary

<a name='P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-DeveloperEmailAddress'></a>

### DeveloperEmailAddress `property`

##### Summary

This email address is for global use of background jobs and other processes
that warrant developer attention if it fails or succeeds

<a name='P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-SendTestEmail'></a>

### SendTestEmail `property`

##### Summary

Should a test email be used?

<a name='P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-TestEmailAddress'></a>

### TestEmailAddress `property`

##### Summary

This email address is used for automated testing

<a name='P-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-TestEmailEnvironmentToken'></a>

### TestEmailEnvironmentToken `property`

##### Summary

Test email's environment token

<a name='M-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-GetDeveloperEmailAddress-System-String-'></a>

### GetDeveloperEmailAddress(environmentName) `method`

##### Summary

Returns developer account email address for specified environment

##### Returns

##### Parameters

| Name            | Type                                                                                                                    | Description |
| --------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| environmentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Mail-EmailSettings-GetRecipientEmailOrTest-System-String,System-String,System-Boolean-'></a>

### GetRecipientEmailOrTest(email,environmentName,isProduction) `method`

##### Summary

Handles determining if we are sending a test e-mail or not, and creates a list containing the appropriate address.

##### Returns

Returns a list containing the appropriate address. Returns an empty list if we're not on production and environment variables don't indicate to send a test e-mail.

##### Parameters

| Name            | Type                                                                                                                       | Description                   |
| --------------- | -------------------------------------------------------------------------------------------------------------------------- | ----------------------------- |
| email           | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")    | The intended recipient e-mail |
| environmentName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")    |                               |
| isProduction    | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean") |                               |

<a name='T-AndcultureCode-CSharp-Core-Utilities-Security-EncryptionUtils'></a>

## EncryptionUtils `type`

##### Namespace

RSM.HCD.CSharp.Core.Utilities.Security

##### Summary

Commonly used encryption related functionality

<a name='M-AndcultureCode-CSharp-Core-Utilities-Security-EncryptionUtils-GenerateHash-System-String,System-String,System-Int32,System-UInt16-'></a>

### GenerateHash(value,salt,iterationCount,bits) `method`

##### Summary

Generates a hash from the given value and salt

##### Returns

Base 64 encoded string of the hash

##### Parameters

| Name           | Type                                                                                                                    | Description                            |
| -------------- | ----------------------------------------------------------------------------------------------------------------------- | -------------------------------------- |
| value          | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Value to hash                          |
| salt           | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Salt to use (base 64 string)           |
| iterationCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 "System.Int32")    | Iterations to perform (at least 10000) |
| bits           | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 "System.UInt16") | Size of the hash in bits               |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Security-EncryptionUtils-GenerateSalt-System-UInt16-'></a>

### GenerateSalt(bits) `method`

##### Summary

Generate a salt to be used for hashing

##### Returns

Base 64 encoded string of the salt

##### Parameters

| Name | Type                                                                                                                    | Description                                                    |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------- |
| bits | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 "System.UInt16") | Size of the salt to generate in bits (must be a multiple of 8) |

<a name='T-AndcultureCode-CSharp-Core-Cultures-EnglishUnitedStates'></a>

## EnglishUnitedStates `type`

##### Namespace

RSM.HCD.CSharp.Core.Cultures

##### Summary

Localization Culture for United States English (en-US)

<a name='P-AndcultureCode-CSharp-Core-Cultures-EnglishUnitedStates-Code'></a>

### Code `property`

##### Summary

_Inherit from parent._

<a name='P-AndcultureCode-CSharp-Core-Cultures-EnglishUnitedStates-IsDefault'></a>

### IsDefault `property`

##### Summary

_Inherit from parent._

<a name='T-AndcultureCode-CSharp-Core-Models-Entities-Entity'></a>

## Entity `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Entities

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Entity-Id'></a>

### Id `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='T-AndcultureCode-CSharp-Core-Constants-EnvironmentConstants'></a>

## EnvironmentConstants `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Common environment related values

<a name='F-AndcultureCode-CSharp-Core-Constants-EnvironmentConstants-TESTING'></a>

### TESTING `constants`

##### Summary

Testing environment identifier

<a name='T-AndcultureCode-CSharp-Core-Models-Errors-Error'></a>

## Error `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Errors

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-Error-ErrorType'></a>

### ErrorType `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-Error-Key'></a>

### Key `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-Error-Message'></a>

### Message `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='T-AndcultureCode-CSharp-Core-Constants-ErrorConstants'></a>

## ErrorConstants `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Constants class to hold generic error keys and messages.

<a name='F-AndcultureCode-CSharp-Core-Constants-ErrorConstants-ERROR_RESOURCE_NOT_FOUND_KEY'></a>

### ERROR_RESOURCE_NOT_FOUND_KEY `constants`

##### Summary

Error key for when a resource/object cannot be located (soft-deleted, does not exist, etc.)

<a name='T-AndcultureCode-CSharp-Core-Utilities-Security-GuidUtils'></a>

## GuidUtils `type`

##### Namespace

RSM.HCD.CSharp.Core.Utilities.Security

##### Summary

Guid related helper functions

<a name='M-AndcultureCode-CSharp-Core-Utilities-Security-GuidUtils-IsInvalid-System-String-'></a>

### IsInvalid() `method`

##### Summary

Is the supplied string an invalid GUID?

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Utilities-Security-GuidUtils-IsValid-System-String-'></a>

### IsValid() `method`

##### Summary

Is the supplied string an valid GUID?

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Constants-HttpHeaders'></a>

## HttpHeaders `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Common HTTP headers

<a name='F-AndcultureCode-CSharp-Core-Constants-HttpHeaders-X_FORWARDED_FOR'></a>

### X_FORWARDED_FOR `constants`

##### Summary

Originating IP Address
https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Forwarded-For

<a name='T-AndcultureCode-CSharp-Core-Enumerations-HttpVerb'></a>

## HttpVerb `type`

##### Namespace

RSM.HCD.CSharp.Core.Enumerations

##### Summary

Enumeration of HttpVerbs

TODO: Consider using Microsoft.AspNet.Mvc.HttpVerbs enum

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Hosting-IAndcultureCodeWebHostBuilder'></a>

## IAndcultureCodeWebHostBuilder `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Hosting

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Hosting-IAndcultureCodeWebHostBuilder-Args'></a>

### Args `property`

##### Summary

The command line args to dotnet process. Ultimately piped to AspNetCore WebHost.

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Hosting-IAndcultureCodeWebHostBuilder-CreateDefaultBuilder'></a>

### CreateDefaultBuilder() `method`

##### Summary

Simple wrapper around AspNetCore WebHost.CreateDefaultBuilder
to support our own extensibility model

##### Returns

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Extensions-IAndcultureCodeWebHostBuilderExtensions'></a>

## IAndcultureCodeWebHostBuilderExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

<a name='F-AndcultureCode-CSharp-Core-Extensions-IAndcultureCodeWebHostBuilderExtensions-ASPNETCORE_ENVIRONMENT'></a>

### ASPNETCORE_ENVIRONMENT `constants`

##### Summary

Literal string representation of the Core Environment

<a name='M-AndcultureCode-CSharp-Core-Extensions-IAndcultureCodeWebHostBuilderExtensions-PreloadAmazonElasticBeanstalk-AndcultureCode-CSharp-Core-Interfaces-Hosting-IAndcultureCodeWebHostBuilder,System-Boolean,AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider-'></a>

### PreloadAmazonElasticBeanstalk(builder,stdoutEnabled,configurationProvider) `method`

##### Summary

Configures resources from Amazon Elastic Beanstalk (EB) before AspNetCore
is started up. Namely, reading of ASPNET environment

##### Returns

##### Parameters

| Name                  | Type                                                                                                                                                                                                                                         | Description                                                                                            |
| --------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------ |
| builder               | [RSM.HCD.CSharp.Core.Interfaces.Hosting.IAndcultureCodeWebHostBuilder](#T-AndcultureCode-CSharp-Core-Interfaces-Hosting-IAndcultureCodeWebHostBuilder "RSM.HCD.CSharp.Core.Interfaces.Hosting.IAndcultureCodeWebHostBuilder")                |                                                                                                        |
| stdoutEnabled         | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                   | Should errors be output to standard output for debugging being this could be run before logging starts |
| configurationProvider | [RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider](#T-AndcultureCode-CSharp-Core-Utilities-Configuration-AmazonEBConfigurationProvider "RSM.HCD.CSharp.Core.Utilities.Configuration.AmazonEBConfigurationProvider") | TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37                                          |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Data-IApplicationContext'></a>

## IApplicationContext `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Data

##### Summary

Base application context containing commonly leveraged system-level entities

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Data-IApplicationContext-Acls'></a>

### Acls `property`

##### Summary

Access control lists

<a name='T-AndcultureCode-CSharp-Core-Extensions-IConfigurationBuilderExtensions'></a>

## IConfigurationBuilderExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

<a name='M-AndcultureCode-CSharp-Core-Extensions-IConfigurationBuilderExtensions-AddAmazonElasticBeanstalk-Microsoft-Extensions-Configuration-IConfigurationBuilder-'></a>

### AddAmazonElasticBeanstalk(configurationBuilder) `method`

##### Summary

Configures dotnet IConfigurationBuilder to read Amazon Elastic Beanstalk instance environment variables

##### Returns

##### Parameters

| Name                 | Type                                                                                                                                                                               | Description |
| -------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| configurationBuilder | [Microsoft.Extensions.Configuration.IConfigurationBuilder](#T-Microsoft-Extensions-Configuration-IConfigurationBuilder "Microsoft.Extensions.Configuration.IConfigurationBuilder") |             |

##### Example

```
new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddAmazonElasticBeanstalk()
    .AddEnvironmentVariables();
```

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection'></a>

## IConnection `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Data

##### Summary

Describes standard database connection

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-AdditionalParameters'></a>

### AdditionalParameters `property`

##### Summary

Additional custom configuration parameters

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-Database'></a>

### Database `property`

##### Summary

Name of database

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-Datasource'></a>

### Datasource `property`

##### Summary

Url/Name for server

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-Password'></a>

### Password `property`

##### Summary

Hopefully a secure password

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-UserId'></a>

### UserId `property`

##### Summary

User identifier

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IConnection-ToString-System-String-'></a>

### ToString() `method`

##### Summary

Single flattened string representation for the connection

##### Returns

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Interfaces-ICulture'></a>

## ICulture `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces

<a name='P-AndcultureCode-CSharp-Core-Interfaces-ICulture-Code'></a>

### Code `property`

##### Summary

RFC-4646 5-character Culture code (xx-XX)

<a name='P-AndcultureCode-CSharp-Core-Interfaces-ICulture-IsDefault'></a>

### IsDefault `property`

##### Summary

Is this the default locale in the application? There can only be one

<a name='T-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions'></a>

## ICultureExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

<a name='M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-Default-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture}-'></a>

### Default(cultures) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name     | Type                                                                                                                                                                                                                                                                                 | Description |
| -------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ----------- |
| cultures | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}") |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-Exists-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture},System-String-'></a>

### Exists(cultures,cultureCode) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                                                                                                                                                 | Description |
| ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ----------- |
| cultures    | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}") |             |
| cultureCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                              |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-ToCultureCodes-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture}-'></a>

### ToCultureCodes(cultures) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name     | Type                                                                                                                                                                                                                                                                                 | Description |
| -------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ----------- |
| cultures | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}") |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-ToCultureCodes-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture},System-String-'></a>

### ToCultureCodes(cultures,delimiter) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                                                                                                                 | Description |
| --------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ----------- |
| cultures  | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}") |             |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                              |             |

##### Exceptions

| Name                                                                                                                                                     | Description |
| -------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException "System.ArgumentException") |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-ToCultureInfo-AndcultureCode-CSharp-Core-Interfaces-ICulture-'></a>

### ToCultureInfo(culture) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name    | Type                                                                                                                                   | Description |
| ------- | -------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| culture | [RSM.HCD.CSharp.Core.Interfaces.ICulture](#T-AndcultureCode-CSharp-Core-Interfaces-ICulture "RSM.HCD.CSharp.Core.Interfaces.ICulture") |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-ICultureExtensions-ToCultureInfos-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-ICulture}-'></a>

### ToCultureInfos(cultures) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name     | Type                                                                                                                                                                                                                                                                                 | Description |
| -------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ----------- |
| cultures | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.ICulture}") |             |

<a name='T-AndcultureCode-CSharp-Core-Extensions-IDistributedCacheExtensions'></a>

## IDistributedCacheExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

Extensions of IDistributedCache

<a name='M-AndcultureCode-CSharp-Core-Extensions-IDistributedCacheExtensions-Get``1-Microsoft-Extensions-Caching-Distributed-IDistributedCache,System-String-'></a>

### Get\`\`1(cache,key) `method`

##### Summary

Retrieve cached value as a desired type.

##### Parameters

| Name  | Type                                                                                                                                                                                     | Description |
| ----- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| cache | [Microsoft.Extensions.Caching.Distributed.IDistributedCache](#T-Microsoft-Extensions-Caching-Distributed-IDistributedCache "Microsoft.Extensions.Caching.Distributed.IDistributedCache") |             |
| key   | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                  |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IDistributedCacheExtensions-Serialize``1-Microsoft-Extensions-Caching-Distributed-IDistributedCache,``0-'></a>

### Serialize\`\`1(cache,value) `method`

##### Summary

Serialize data to be cached

##### Returns

##### Parameters

| Name  | Type                                                                                                                                                                                     | Description |
| ----- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| cache | [Microsoft.Extensions.Caching.Distributed.IDistributedCache](#T-Microsoft-Extensions-Caching-Distributed-IDistributedCache "Microsoft.Extensions.Caching.Distributed.IDistributedCache") |             |
| value | [\`\`0](#T-``0 "``0")                                                                                                                                                                    |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IDistributedCacheExtensions-Set``1-Microsoft-Extensions-Caching-Distributed-IDistributedCache,System-String,``0,Microsoft-Extensions-Caching-Distributed-DistributedCacheEntryOptions-'></a>

### Set\`\`1(cache,key,value,options) `method`

##### Summary

Serialize and cache supplied key/value pair

##### Parameters

| Name    | Type                                                                                                                                                                                                                      | Description |
| ------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| cache   | [Microsoft.Extensions.Caching.Distributed.IDistributedCache](#T-Microsoft-Extensions-Caching-Distributed-IDistributedCache "Microsoft.Extensions.Caching.Distributed.IDistributedCache")                                  |             |
| key     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                   |             |
| value   | [\`\`0](#T-``0 "``0")                                                                                                                                                                                                     |             |
| options | [Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions](#T-Microsoft-Extensions-Caching-Distributed-DistributedCacheEntryOptions "Microsoft.Extensions.Caching.Distributed.DistributedCacheEntryOptions") |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Providers-Mail-IEmailProvider'></a>

## IEmailProvider `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Providers.Mail

##### Summary

Generic email provider

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Mail-IEmailProvider-Send-MimeKit-MimeMessage-'></a>

### Send(message) `method`

##### Summary

Send an email immediately

##### Parameters

| Name    | Type                                                                | Description            |
| ------- | ------------------------------------------------------------------- | ---------------------- |
| message | [MimeKit.MimeMessage](#T-MimeKit-MimeMessage "MimeKit.MimeMessage") | The message to be sent |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Mail-IEmailProvider-SendLater-MimeKit-MimeMessage-'></a>

### SendLater(message) `method`

##### Summary

Send an email via a background job

##### Parameters

| Name    | Type                                                                | Description            |
| ------- | ------------------------------------------------------------------- | ---------------------- |
| message | [MimeKit.MimeMessage](#T-MimeKit-MimeMessage "MimeKit.MimeMessage") | The message to be sent |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1'></a>

## ILockingConductor\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Conductors

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1-ExtendLock-System-Int64,System-DateTimeOffset,System-Nullable{System-Int64}-'></a>

### ExtendLock(id,lockUntil,updatedById) `method`

##### Summary

Updates the LockedUntil field for the record, allowing the user that locked
it to have the lock for a longer amount of time.

##### Returns

the updated record if the lock is successfully extended, null otherwise

##### Parameters

| Name        | Type                                                                                                                                                      | Description                                        |
| ----------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------- |
| id          | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                      | The record id                                      |
| lockUntil   | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset "System.DateTimeOffset")           | The time the record should be locked until         |
| updatedById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}") | The id of the user updating the record's lock time |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1-Lock-System-Int64,System-DateTimeOffset,System-Nullable{System-Int64}-'></a>

### Lock(id,lockUntil,lockedById) `method`

##### Summary

Updates the locking fields to be set, which denotes that the user locking the record should
have exclusive access to modifying it for the lock's duration. This, however, does
not prohibit the record from being modified by others. When a record is locked, the
ValidateLock method below should be used to determine if the record can be modified. This will
ensure that only the user that locked the record is actually able to modify its contents.

##### Returns

the updated record if it is successfully locked, null otherwise

##### Parameters

| Name       | Type                                                                                                                                                      | Description                                |
| ---------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------ |
| id         | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                      | The record id                              |
| lockUntil  | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset "System.DateTimeOffset")           | The time the record should be locked until |
| lockedById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}") | The id of the user locking the record      |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1-Unlock-System-Int64,System-Nullable{System-Int64}-'></a>

### Unlock(id,unlockedById) `method`

##### Summary

Updates the locking fields back to null, meaning any user will be able to acquire a lock
so they have exclusive access to editing it.

##### Returns

the updated record if it is successfully unlocked, null otherwise

##### Parameters

| Name         | Type                                                                                                                                                      | Description                             |
| ------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------- |
| id           | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                      | The record id                           |
| unlockedById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}") | The id of the user unlocking the record |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-ILockingConductor`1-ValidateLock-`0,System-Nullable{System-Int64}-'></a>

### ValidateLock(item,currentUserId) `method`

##### Summary

Used to determine whether or not the user attempting to update the record is the
user that has the lock, AND that the lock is still valid (i.e. not expired).

##### Returns

true if the lock is still active and is locked by the current user, false otherwise

##### Parameters

| Name          | Type                                                                                                                                                      | Description         |
| ------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------- |
| item          | [\`0](#T-`0 "`0")                                                                                                                                         | The item            |
| currentUserId | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}") | The current user id |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser'></a>

## IOAuthUser `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Authentication

##### Summary

Base information used to integration OAuth provider users

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-Email'></a>

### Email `property`

##### Summary

Email address

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-FirstName'></a>

### FirstName `property`

##### Summary

Given name / First name

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-Id'></a>

### Id `property`

##### Summary

Uniquely assigned identifier from external oauth provider

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-LastName'></a>

### LastName `property`

##### Summary

Surname / Lastname

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Authentication-IOAuthUser-UserMetadataName'></a>

### UserMetadataName `property`

##### Summary

Which UserMetadata.Name is associated for this OAuth User type

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IPermissionConductor'></a>

## IPermissionConductor `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Conductors

##### Summary

Determines permission leveraging access control lists

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IPermissionConductor-GetAcls-System-String,System-String-'></a>

### GetAcls(resource,verb) `method`

##### Summary

Get a list of Access Rules for a given resource/verb pair.

##### Returns

##### Parameters

| Name     | Type                                                                                                                    | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| resource | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| verb     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IPermissionConductor-IsAllowed-System-String,System-String,System-String-'></a>

### IsAllowed(resource,verb,subject) `method`

##### Summary

Determine if a given Role is allowed to perform a certain action, given as a
resource/verb pair.

##### Returns

##### Parameters

| Name     | Type                                                                                                                    | Description                                              |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------- |
| resource | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |                                                          |
| verb     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |                                                          |
| subject  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | The ID for the Role that we're checking permissions for. |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Providers-IProvider'></a>

## IProvider `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Providers

##### Summary

Foundation configuration for providers

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Providers-IProvider-Implemented'></a>

### Implemented `property`

##### Summary

Specify whether the provider has been implemented

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Providers-IProvider-Name'></a>

### Name `property`

##### Summary

Name of the provider

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IRemoteAccessDetails'></a>

## IRemoteAccessDetails `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Providers.Storage

##### Summary

Access details to access a given storage resource

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IRemoteAccessDetails-Url'></a>

### Url `property`

##### Summary

Url for accessing the given resource

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1'></a>

## IRepositoryConductor\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Conductors

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1-CommandTimeout'></a>

### CommandTimeout `property`

##### Summary

Ability to set and get the underlying DbContext's command timeout

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1-BulkCreateOrUpdate-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}-'></a>

### BulkCreateOrUpdate() `method`

##### Summary

Automatically determines if the supplied entity needs created or updated.

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1-CreateOrUpdate-`0,System-Nullable{System-Int64}-'></a>

### CreateOrUpdate() `method`

##### Summary

Automatically determines if the supplied entity needs created or updated.

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryConductor`1-CreateOrUpdate-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}-'></a>

### CreateOrUpdate(items,createdOrUpdatedById) `method`

##### Summary

Automatically determines if the supplied entities need created or updated.

##### Returns

##### Parameters

| Name                 | Type                                                                                                                                                                                                        | Description |
| -------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| items                | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") |
| createdOrUpdatedById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                   |             |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryCreateConductor`1'></a>

## IRepositoryCreateConductor\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Conductors

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryCreateConductor`1-CommandTimeout'></a>

### CommandTimeout `property`

##### Summary

Ability to set and get the underlying DbContext's command timeout

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryCreateConductor`1-BulkCreateDistinct``1-System-Collections-Generic-IEnumerable{`0},System-Func{`0,``0},System-Nullable{System-Int64}-'></a>

### BulkCreateDistinct\`\`1(items,property,createdById) `method`

##### Summary

Calls BulkCreate() with a de-duped list of objects as determined by the
property (or properties) of the object for the 'property' argument
NOTE: Bulking is generally faster than batching, but locks the table.

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                                                                                                             | Description                                                          |
| ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | -------------------------------------------------------------------- |
| items       | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") | List of items to attempt to create |
| property    | [System.Func{\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{`0,``0}")                                                                                                             | Property or properties of the typed object to determine distinctness |
| createdById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                                                        | Id of the user creating the entity                                   |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryCreateConductor`1-CreateDistinct``1-System-Collections-Generic-IEnumerable{`0},System-Func{`0,``0},System-Nullable{System-Int64}-'></a>

### CreateDistinct\`\`1(items,property,createdById) `method`

##### Summary

Calls batched overload of Create() with a de-duped list of objects as determined by the
property (or properties) of the object for the 'property' argument.
NOTE: Batching is generally slower than bulking, but does not lock the table.

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                                                                                                             | Description                                                          |
| ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | -------------------------------------------------------------------- |
| items       | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") | List of items to attempt to create |
| property    | [System.Func{\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{`0,``0}")                                                                                                             | Property or properties of the typed object to determine distinctness |
| createdById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                                                        | Id of the user creating the entity                                   |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey |             |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryDeleteConductor`1'></a>

## IRepositoryDeleteConductor\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Conductors

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryDeleteConductor`1-CommandTimeout'></a>

### CommandTimeout `property`

##### Summary

Ability to set and get the underlying DbContext's command timeout

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1'></a>

## IRepositoryReadConductor\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Conductors

##### Summary

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-CommandTimeout'></a>

### CommandTimeout `property`

##### Summary

Ability to set and get the underlying DbContext's command timeout

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAll-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean-'></a>

### FindAll(filter,orderBy,includeProperties,skip,take,ignoreQueryFilters,asNoTracking) `method`

##### Summary

Configure lazy loaded queryable, given provided parameters, to load a list of `T`

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                      | Description                                                   |
| ------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| filter             | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Filter to be used for querying. |
| orderBy            | [System.Func{System.Linq.IQueryable{\`0},System.Linq.IOrderedQueryable{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}}")                                           | Properties that should be used for sorting.                   |
| includeProperties  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                   | Navigation properties that should be included.                |
| skip               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                 | Number of entities that should be skipped.                    |
| take               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                 | Number of entities per page.                                  |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                                                             | If true, global query filters will be ignored for this query. |
| asNoTracking       | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                                                                | Ignore change tracking on the result. Set                     |

```
true
```

for read-only operations. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAll-System-Collections-Generic-Dictionary{System-String,System-String},System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Nullable{System-Boolean},System-Boolean-'></a>

### FindAll(filter,orderBy,nextLinkParams,ignoreQueryFilters,asNoTracking) `method`

##### Summary

Alternative FindAll for retrieving records using NextLinkParams in place of traditional
determinate pagination mechanisms, such as; skip and take.

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                                  | Description                                                   |
| ------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| filter             | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary "System.Collections.Generic.Dictionary{System.String,System.String}")                                             | Filter to be used for querying.                               |
| orderBy            | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Properties that should be used for sorting. |
| nextLinkParams     | [System.Func{System.Linq.IQueryable{\`0},System.Linq.IOrderedQueryable{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}}")                                                       |                                                               |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                                                                         | If true, global query filters will be ignored for this query. |
| asNoTracking       | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                                                                            | Ignore change tracking on the result. Set                     |

```
true
```

for read-only operations. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAllCommitted-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean}-'></a>

### FindAllCommitted(filter,orderBy,includeProperties,skip,take,ignoreQueryFilters) `method`

##### Summary

Similar to FindAll, this evaluates the parameters as given. The big difference here is that the query is executed
inside the conductor and a List`T` is returned and NOT Queryable`T`. This is primary used in cases where calculated
fields need to be executed (committed) inside the conductor.

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                      | Description                                                   |
| ------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| filter             | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Filter to be used for querying. |
| orderBy            | [System.Func{System.Linq.IQueryable{\`0},System.Linq.IOrderedQueryable{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}}")                                           | Properties that should be used for sorting.                   |
| includeProperties  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                   | Navigation properties that should be included.                |
| skip               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                 | Number of entities that should be skipped.                    |
| take               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                 | Number of entities per page.                                  |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                                                             | If true, global query filters will be ignored for this query. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAllCommitted-System-Collections-Generic-Dictionary{System-String,System-String},System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Nullable{System-Boolean}-'></a>

### FindAllCommitted(filter,orderBy,nextLinkParams,ignoreQueryFilters) `method`

##### Summary

Alternative FindAll for retrieving records using NextLinkParams in place of traditional
determinate pagination mechanisms, such as; skip and take.

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                                  | Description                                                   |
| ------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| filter             | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary "System.Collections.Generic.Dictionary{System.String,System.String}")                                             | Filter to be used for querying.                               |
| orderBy            | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Properties that should be used for sorting. |
| nextLinkParams     | [System.Func{System.Linq.IQueryable{\`0},System.Linq.IOrderedQueryable{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}}")                                                       |                                                               |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                                                                         | If true, global query filters will be ignored for this query. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAll``1-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Linq-Expressions-Expression{System-Func{`0,``0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean-'></a>

### FindAll\`\`1(filter,orderBy,groupBy,includeProperties,skip,take,ignoreQueryFilters,asNoTracking) `method`

##### Summary

Configure lazy loaded queryable, given provided parameters, to load a list of `T` grouped by a `TKey`

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                      | Description                                                   |
| ------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| filter             | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Filter to be used for querying. |
| orderBy            | [System.Func{System.Linq.IQueryable{\`0},System.Linq.IOrderedQueryable{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}}")                                           | Properties that should be used for sorting.                   |
| groupBy            | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,``0}}")                                                       | Filter to be used for grouping by `TKey` of `T` .             |
| includeProperties  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                   | Navigation properties that should be included.                |
| skip               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                 | Number of entities that should be skipped.                    |
| take               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                 | Number of entities per page.                                  |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                                                             | If true, global query filters will be ignored for this query. |
| asNoTracking       | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                                                                | Ignore change tracking on the result. Set                     |

```
true
```

for read-only operations. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindAll``2-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Linq-Expressions-Expression{System-Func{`0,``0}},System-Linq-Expressions-Expression{System-Func{``0,System-Collections-Generic-IEnumerable{`0},``1}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean-'></a>

### FindAll\`\`2(filter,orderBy,groupBy,groupBySelector,includeProperties,skip,take,ignoreQueryFilters,asNoTracking) `method`

##### Summary

Configure lazy loaded queryable, given provided parameters, to load a list of `T`
grouped by a `TKey` and selected by groupBySelector tranformed into `TResult`
ref to microsoft docs: https://shorturl.at/jptP3

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                                                          | Description                                                                                |
| ------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------ |
| filter             | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Filter to be used for querying.                                     |
| orderBy            | [System.Func{System.Linq.IQueryable{\`0},System.Linq.IOrderedQueryable{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}}")                                                                               | Properties that should be used for sorting.                                                |
| groupBy            | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,``0}}")                                                                                           | Filter to be used for grouping by `TKey` of `T` .                                          |
| groupBySelector    | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Collections.Generic.IEnumerable{\`0},\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Collections.Generic.IEnumerable{`0},``1}}") | Selector to be used on groupBy used to create a result of `TResult` value from each group. |
| includeProperties  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                                                       | Navigation properties that should be included.                                             |
| skip               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                                                     | Number of entities that should be skipped.                                                 |
| take               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                                                     | Number of entities per page.                                                               |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                                                                                                 | If true, global query filters will be ignored for this query.                              |
| asNoTracking       | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                                                                                                    | Ignore change tracking on the result. Set                                                  |

```
true
```

for read-only operations. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64-'></a>

### FindById(id) `method`

##### Summary

Finds an entity by its Id.

##### Returns

The entity with the provided identity value.

##### Parameters

| Name | Type                                                                                                                 | Description                |
| ---- | -------------------------------------------------------------------------------------------------------------------- | -------------------------- |
| id   | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64") | The entity identity value. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}-'></a>

### FindById(id,filter) `method`

##### Summary

Finds an entity by its Id that also matches a filter.

##### Returns

The entity witht he provided identity value and filter condition met.

##### Parameters

| Name   | Type                                                                                                                                                                                                                                                                                      | Description                |
| ------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------- |
| id     | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                      | The entity identity value. |
| filter | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Filter to be used for querying. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64,System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]-'></a>

### FindById(id,includeProperties) `method`

##### Summary

Finds an entity by its Id.

##### Returns

The entity with the provided identity value.

##### Parameters

| Name              | Type                                                                                                                                                                                                                                                                                                       | Description                |
| ----------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------- |
| id                | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                                       | The entity identity value. |
| includeProperties | [System.Linq.Expressions.Expression{System.Func{\`0,System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[]") | Navigation properties that should be included. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64,System-Boolean,System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]-'></a>

### FindById(id,ignoreQueryFilters,includeProperties) `method`

##### Summary

Finds an entity by its Id.

##### Returns

The entity with the provided identity value.

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                                       | Description                                                   |
| ------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| id                 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                                       | The entity identity value.                                    |
| ignoreQueryFilters | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                                                                                 | If true, global query filters will be ignored for this query. |
| includeProperties  | [System.Linq.Expressions.Expression{System.Func{\`0,System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[]") | Navigation properties that should be included. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryReadConductor`1-FindById-System-Int64,System-String[]-'></a>

### FindById(id,includeProperties) `method`

##### Summary

Finds an entity by its Id.

##### Returns

The entity with the provided identity value.

##### Parameters

| Name              | Type                                                                                                                          | Description                                    |
| ----------------- | ----------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------- |
| id                | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")          | The entity identity value.                     |
| includeProperties | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] "System.String[]") | Navigation properties that should be included. |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryUpdateConductor`1'></a>

## IRepositoryUpdateConductor\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Conductors

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Conductors-IRepositoryUpdateConductor`1-CommandTimeout'></a>

### CommandTimeout `property`

##### Summary

Ability to set and get the underlying DbContext's command timeout

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1'></a>

## IRepository\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Data

##### Summary

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-CommandTimeout'></a>

### CommandTimeout `property`

##### Summary

Ability to set and get the underlying DbContext's command timeout

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-BulkCreate-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}-'></a>

### BulkCreate(items,createdById) `method`

##### Summary

Perform a DbContext.BulkInsert on an enumeration of T within a single transaction

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                                                                        | Description |
| ----------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| items       | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") |
| createdById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                   |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-BulkCreateDistinct``1-System-Collections-Generic-IEnumerable{`0},System-Func{`0,``0},System-Nullable{System-Int64}-'></a>

### BulkCreateDistinct\`\`1(items,property,createdById,items,property,createdById) `method`

##### Summary

Calls BulkCreate() with a de-duped list of objects as determined by the
property (or properties) of the object for the 'property' argument
NOTE: Bulking is generally faster than batching, but locks the table.

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                                                                                                             | Description                                                          |
| ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | -------------------------------------------------------------------- |
| items       | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") | List of items to attempt to create |
| property    | [System.Func{\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{`0,``0}")                                                                                                             | Property or properties of the typed object to determine distinctness |
| createdById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                                                        | Id of the user creating the entity                                   |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey |             |
| TKey |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-BulkDelete-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64},System-Boolean-'></a>

### BulkDelete(items,deletedById,soft) `method`

##### Summary

Calls BulkDelete() with a de-duped list of objects as determined by the
property (or properties) of the object for the 'property' argument
NOTE: Bulking is generally faster than batching, but locks the table.

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                                                                        | Description |
| ----------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| items       | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") |
| deletedById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                   |             |
| soft        | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                  |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-BulkUpdate-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}-'></a>

### BulkUpdate(entities,updatedBy) `method`

##### Summary

Ability to update a list of entities in a single bulk operation.

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                                                                  | Description                    |
| --------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------ |
| entities  | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") | List of items to update |
| updatedBy | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                                             | Id of user updating the entity |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Create-`0,System-Nullable{System-Int64}-'></a>

### Create(item,createdById) `method`

##### Summary

Ability to create an entity

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                      | Description                  |
| ----------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------- |
| item        | [\`0](#T-`0 "`0")                                                                                                                                         | Item to be created           |
| createdById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}") | Id of user creating the item |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Create-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}-'></a>

### Create(items,createdById) `method`

##### Summary

Ability to create entities individually using a list

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                                                                                                      | Description                   |
| ----------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------- |
| items       | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") | List of items to be created |
| createdById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                                                 | Id of user creating the items |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-CreateDistinct``1-System-Collections-Generic-IEnumerable{`0},System-Func{`0,``0},System-Nullable{System-Int64}-'></a>

### CreateDistinct\`\`1(items,property,createdById) `method`

##### Summary

Calls batched overload of Create() with a de-duped list of objects as determined by the
property (or properties) of the object for the 'property' argument.
NOTE: Batching is generally slower than bulking, but does not lock the table.

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                                                                                                             | Description                                                          |
| ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | -------------------------------------------------------------------- |
| items       | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") | List of items to attempt to create |
| property    | [System.Func{\`0,\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{`0,``0}")                                                                                                             | Property or properties of the typed object to determine distinctness |
| createdById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                                                        | Id of the user creating the entity                                   |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Delete-System-Int64,System-Nullable{System-Int64},System-Boolean-'></a>

### Delete(id,deletedById,soft) `method`

##### Summary

Ability to delete an entity using an Id

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                      | Description                             |
| ----------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------- |
| id          | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                      | Id of item to be deleted                |
| deletedById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}") | Id of user deleting the item            |
| soft        | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                | Boolean flag for soft-deleting the item |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Delete-`0,System-Nullable{System-Int64},System-Boolean-'></a>

### Delete(o,deletedById,soft) `method`

##### Summary

Ability to delete an entity using the entity itself

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                      | Description                             |
| ----------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------- |
| o           | [\`0](#T-`0 "`0")                                                                                                                                         | Item to be deleted                      |
| deletedById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}") | Id of user deleting the item            |
| soft        | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                | Boolean flag for soft-deleting the item |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Delete-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64},System-Int64,System-Boolean-'></a>

### Delete(items,deletedById,batchSize,soft) `method`

##### Summary

Ability to delete a list of entities by batch size.

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                                                                                                  | Description                                            |
| ----------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------ |
| items       | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") | List of items to delete |
| deletedById | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                                             | Id of user deleting the items                          |
| batchSize   | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                  | Number of items to include in a batch, defaults to 100 |
| soft        | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                            | Boolean flag for soft-deleting the items               |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindAll-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean-'></a>

### FindAll(filter,orderBy,includeProperties,skip,take,ignoreQueryFilters,asNoTracking) `method`

##### Summary

Find all filtered, sorted and paged

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                    | Description |
| ------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| filter             | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") |
| orderBy            | [System.Func{System.Linq.IQueryable{\`0},System.Linq.IOrderedQueryable{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}}")         |             |
| includeProperties  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                 |             |
| skip               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                               |             |
| take               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                               |             |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                           |             |
| asNoTracking       | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                              |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindAll``1-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Linq-Expressions-Expression{System-Func{`0,``0}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean-'></a>

### FindAll\`\`1(filter,orderBy,groupBy,includeProperties,skip,take,ignoreQueryFilters,asNoTracking) `method`

##### Summary

Configure lazy loaded queryable, given provided parameters, to load a list of `T` grouped by a `TKey`

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                      | Description                                                   |
| ------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| filter             | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Filter to be used for querying. |
| orderBy            | [System.Func{System.Linq.IQueryable{\`0},System.Linq.IOrderedQueryable{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}}")                                           | Properties that should be used for sorting.                   |
| groupBy            | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,``0}}")                                                       | Filter to be used for grouping by `TKey` of `T` .             |
| includeProperties  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                   | Navigation properties that should be included.                |
| skip               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                 | Number of entities that should be skipped.                    |
| take               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                 | Number of entities per page.                                  |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                                                             | If true, global query filters will be ignored for this query. |
| asNoTracking       | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                                                                | Ignore change tracking on the result. Set                     |

```
true
```

for read-only operations. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindAll``2-System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}},System-Func{System-Linq-IQueryable{`0},System-Linq-IOrderedQueryable{`0}},System-Linq-Expressions-Expression{System-Func{`0,``0}},System-Linq-Expressions-Expression{System-Func{``0,System-Collections-Generic-IEnumerable{`0},``1}},System-String,System-Nullable{System-Int32},System-Nullable{System-Int32},System-Nullable{System-Boolean},System-Boolean-'></a>

### FindAll\`\`2(filter,orderBy,groupBy,groupBySelector,includeProperties,skip,take,ignoreQueryFilters,asNoTracking) `method`

##### Summary

Configure lazy loaded queryable, given provided parameters, to load a list of `T`
grouped by a `TKey` and selected by groupBySelector tranformed into `TResult`
ref to: https://docs.microsoft.com/en-us/dotnet/api/system.linq.queryable.groupby?view=netcore-3.1#System_Linq_Queryable_GroupBy__3_System_Linq_IQueryable___0__System_Linq_Expressions_Expression_System_Func___0___1___System_Linq_Expressions_Expression_System_Func___1_System_Collections_Generic_IEnumerable___0____2___

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                                                          | Description                                                                                |
| ------------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------ |
| filter             | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Filter to be used for querying.                                     |
| orderBy            | [System.Func{System.Linq.IQueryable{\`0},System.Linq.IOrderedQueryable{\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{System.Linq.IQueryable{`0},System.Linq.IOrderedQueryable{`0}}")                                                                               | Properties that should be used for sorting.                                                |
| groupBy            | [System.Linq.Expressions.Expression{System.Func{\`0,\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,``0}}")                                                                                           | Filter to be used for grouping by `TKey` of `T` .                                          |
| groupBySelector    | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Collections.Generic.IEnumerable{\`0},\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Collections.Generic.IEnumerable{`0},``1}}") | Selector to be used on groupBy used to create a result of `TResult` value from each group. |
| includeProperties  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                                                       | Navigation properties that should be included.                                             |
| skip               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                                                     | Number of entities that should be skipped.                                                 |
| take               | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int32}")                                                                                                                                                                     | Number of entities per page.                                                               |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                                                                                                 | If true, global query filters will be ignored for this query.                              |
| asNoTracking       | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                                                                                                                                    | Ignore change tracking on the result. Set                                                  |

```
true
```

for read-only operations. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-Nullable{System-Boolean}-'></a>

### FindById(id,ignoreQueryFilters) `method`

##### Summary

Finds an entity by its Id.

##### Returns

The entity with the provided identity value.

##### Parameters

| Name               | Type                                                                                                                                                          | Description                                                   |
| ------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| id                 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                          | The entity identity value.                                    |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}") | If true, global query filters will be ignored for this query. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-Linq-Expressions-Expression{System-Func{`0,System-Boolean}}-'></a>

### FindById(id,filter) `method`

##### Summary

Finds an entity by its Id that also matches a filter.

##### Returns

The entity witht he provided identity value and filter condition met.

##### Parameters

| Name   | Type                                                                                                                                                                                                                                                                                      | Description                |
| ------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------- |
| id     | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                      | The entity identity value. |
| filter | [System.Linq.Expressions.Expression{System.Func{\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Boolean}}") | Filter to be used for querying. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]-'></a>

### FindById(id,includeProperties) `method`

##### Summary

Finds an entity by its Id.

##### Returns

The entity with the provided identity value.

##### Parameters

| Name              | Type                                                                                                                                                                                                                                                                                                       | Description                |
| ----------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------- |
| id                | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                                       | The entity identity value. |
| includeProperties | [System.Linq.Expressions.Expression{System.Func{\`0,System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[]") | Navigation properties that should be included. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-Nullable{System-Boolean},System-Linq-Expressions-Expression{System-Func{`0,System-Object}}[]-'></a>

### FindById(id,ignoreQueryFilters,includeProperties) `method`

##### Summary

Finds an entity by its Id.

##### Returns

The entity with the provided identity value.

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                                       | Description                                                   |
| ------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| id                 | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                                                       | The entity identity value.                                    |
| ignoreQueryFilters | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Boolean}")                                                                                                                                              | If true, global query filters will be ignored for this query. |
| includeProperties  | [System.Linq.Expressions.Expression{System.Func{\`0,System.Object}}[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{`0,System.Object}}[]") | Navigation properties that should be included. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-FindById-System-Int64,System-String[]-'></a>

### FindById(id,includeProperties) `method`

##### Summary

Finds an entity by its Id.

##### Returns

The entity with the provided identity value.

##### Parameters

| Name              | Type                                                                                                                          | Description                                    |
| ----------------- | ----------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------- |
| id                | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")          | The entity identity value.                     |
| includeProperties | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] "System.String[]") | Navigation properties that should be included. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Restore-`0-'></a>

### Restore(o) `method`

##### Summary

Ability to restore a soft-deleted entity using the entity itself.

##### Returns

##### Parameters

| Name | Type              | Description           |
| ---- | ----------------- | --------------------- |
| o    | [\`0](#T-`0 "`0") | Entity to be restored |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Restore-System-Int64-'></a>

### Restore(id) `method`

##### Summary

Ability to restore a soft-deleted entity using the entity id.

##### Returns

##### Parameters

| Name | Type                                                                                                                 | Description                 |
| ---- | -------------------------------------------------------------------------------------------------------------------- | --------------------------- |
| id   | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64") | Id of entity to be restored |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Update-`0,System-Nullable{System-Int64}-'></a>

### Update(item,updatedBy) `method`

##### Summary

Ability to create or update an entity

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                      | Description                                |
| --------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------ |
| item      | [\`0](#T-`0 "`0")                                                                                                                                         | Item to create or update                   |
| updatedBy | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}") | Id of user creating or updating the entity |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Data-IRepository`1-Update-System-Collections-Generic-IEnumerable{`0},System-Nullable{System-Int64}-'></a>

### Update(entities,updatedBy) `method`

##### Summary

Calls Update one-by-one for each item in the enumerated entities.
For large operations, BulkUpdate() is more efficient.

##### Returns

True if entities updated without any exceptions. False if an exception was thrown.

##### Parameters

| Name      | Type                                                                                                                                                                                                        | Description |
| --------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| entities  | [System.Collections.Generic.IEnumerable{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{`0}") |
| updatedBy | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}")                                                   |             |

<a name='T-AndcultureCode-CSharp-Core-Extensions-IResultExtensions'></a>

## IResultExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,System-String,System-String,System-Nullable{System-Int64}-'></a>

### AddErrorAndLog\`\`1(result,logger,errorKey,errorMessage,resourceIdentifier) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Parameters

| Name               | Type                                                                                                                                                      | Description |
| ------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result             | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")      |             |
| logger             | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                    |             |
| errorKey           | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                   |             |
| errorMessage       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                   |             |
| resourceIdentifier | [System.Nullable{System.Int64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.Int64}") |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Object[]-'></a>

### AddErrorAndLog\`\`1(result,logger,localizer,errorKey,arguments) `method`

##### Summary

Add translated error record and log un-translated message

##### Parameters

| Name      | Type                                                                                                                                                             | Description                                                  |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")             |                                                              |
| logger    | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                           |                                                              |
| localizer | [Microsoft.Extensions.Localization.IStringLocalizer](#T-Microsoft-Extensions-Localization-IStringLocalizer "Microsoft.Extensions.Localization.IStringLocalizer") |                                                              |
| errorKey  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                          | Error key found in culture files                             |
| arguments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] "System.Object[]")                                    | The values with which to format the translated error message |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Int64,System-Object[]-'></a>

### AddErrorAndLog\`\`1(result,logger,localizer,errorKey,resourceIdentifier,arguments) `method`

##### Summary

Add translated error record and log un-translated message

##### Parameters

| Name               | Type                                                                                                                                                             | Description                                                  |
| ------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| result             | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")             |                                                              |
| logger             | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                           |                                                              |
| localizer          | [Microsoft.Extensions.Localization.IStringLocalizer](#T-Microsoft-Extensions-Localization-IStringLocalizer "Microsoft.Extensions.Localization.IStringLocalizer") |                                                              |
| errorKey           | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                          | Error key found in culture files                             |
| resourceIdentifier | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                             |                                                              |
| arguments          | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] "System.Object[]")                                    | The values with which to format the translated error message |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Object[]-'></a>

### AddError\`\`1(result,localizer,key,arguments) `method`

##### Summary

Add translated error record of type Error

##### Parameters

| Name      | Type                                                                                                                                                             | Description                                                  |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")             |                                                              |
| localizer | [Microsoft.Extensions.Localization.IStringLocalizer](#T-Microsoft-Extensions-Localization-IStringLocalizer "Microsoft.Extensions.Localization.IStringLocalizer") |                                                              |
| key       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                          | Error key found in culture files                             |
| arguments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] "System.Object[]")                                    | The values with which to format the translated error message |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Interfaces-IError-'></a>

### AddError\`\`1(result,error) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                 | Description |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| error  | [RSM.HCD.CSharp.Core.Interfaces.IError](#T-AndcultureCode-CSharp-Core-Interfaces-IError "RSM.HCD.CSharp.Core.Interfaces.IError")                     |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Enumerations-ErrorType,System-String,System-String-'></a>

### AddError\`\`1(result,errorType,key,message) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                 | Description |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| errorType | [RSM.HCD.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType "RSM.HCD.CSharp.Core.Enumerations.ErrorType")      |             |
| key       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |
| message   | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Localization-IStringLocalizer,AndcultureCode-CSharp-Core-Enumerations-ErrorType,System-String,System-Object[]-'></a>

### AddError\`\`1(result,localizer,key,arguments) `method`

##### Summary

Add translated error record

##### Parameters

| Name      | Type                                                                                                                                                             | Description                                                  |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")             |                                                              |
| localizer | [Microsoft.Extensions.Localization.IStringLocalizer](#T-Microsoft-Extensions-Localization-IStringLocalizer "Microsoft.Extensions.Localization.IStringLocalizer") |                                                              |
| key       | [RSM.HCD.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType "RSM.HCD.CSharp.Core.Enumerations.ErrorType")                  | Error key found in culture files                             |
| arguments | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                          | The values with which to format the translated error message |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-String-'></a>

### AddError\`\`1(result,key,message) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name    | Type                                                                                                                                                 | Description |
| ------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result  | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| key     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String-'></a>

### AddError\`\`1(result,message) `method`

##### Summary

Adds a new error with the calling class and method name as the key

##### Returns

##### Parameters

| Name    | Type                                                                                                                                                 | Description |
| ------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result  | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,System-String,System-String,System-Int64,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>

### AddErrorsAndLog\`\`1(result,logger,errorKey,errorMessage,resourceIdentifier,errors) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                             | Description |
| ------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result             | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")                                                                                                                             |             |
| logger             | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                                                                                                                                           |             |
| errorKey           | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          |             |
| errorMessage       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          |             |
| resourceIdentifier | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                             |             |
| errors             | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}") |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,System-String,System-String,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>

### AddErrorsAndLog\`\`1(result,logger,errorKey,errorMessage,errors) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Parameters

| Name         | Type                                                                                                                                                                                                                                                                             | Description |
| ------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result       | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")                                                                                                                             |             |
| logger       | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                                                                                                                                           |             |
| errorKey     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          |             |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          |             |
| errors       | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}") |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,System-String,System-String,System-String,System-String,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},System-String-'></a>

### AddErrorsAndLog\`\`1(result,logger,errorKey,errorMessage,logMessage,resourceIdentifier,errors,methodName) `method`

##### Summary

Add error record and log message

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                             | Description                                                                      |
| ------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| result             | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")                                                                                                                             |                                                                                  |
| logger             | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                                                                                                                                           |                                                                                  |
| errorKey           | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          | Error key found in culture files                                                 |
| errorMessage       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          | Translated error message                                                         |
| logMessage         | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          | Log message - commonly un-translated version of errorMessage                     |
| resourceIdentifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          |                                                                                  |
| errors             | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}") | Additional errors to forward. These are assumed to have already been translated. |
| methodName         | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          | Name of calling method for use in log message for improved debugging             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndLog``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Int64,System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError},System-Object[]-'></a>

### AddErrorsAndLog\`\`1(result,logger,localizer,errorKey,resourceIdentifier,errors,arguments) `method`

##### Summary

Add translated error record and log un-translated message

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                             | Description                                                                      |
| ------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| result             | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")                                                                                                                             |                                                                                  |
| logger             | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger "Microsoft.Extensions.Logging.ILogger")                                                                                                                                                           |                                                                                  |
| localizer          | [Microsoft.Extensions.Localization.IStringLocalizer](#T-Microsoft-Extensions-Localization-IStringLocalizer "Microsoft.Extensions.Localization.IStringLocalizer")                                                                                                                 |                                                                                  |
| errorKey           | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                          | Error key found in culture files                                                 |
| resourceIdentifier | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                                             |                                                                                  |
| errors             | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}") | Additional errors to forward. These are assumed to have already been translated. |
| arguments          | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] "System.Object[]")                                                                                                                                                    | The values with which to format the translated error message                     |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrorsAndReturnDefault``2-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Interfaces-IResult{``1}-'></a>

### AddErrorsAndReturnDefault\`\`2(destination,source) `method`

##### Summary

Convenience method to simplify common scenario of bubbling errors and
returning null (or default for T type) to the parent

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                 | Description |
| ----------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| destination | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| source      | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`1}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``1} "RSM.HCD.CSharp.Core.Interfaces.IResult{``1}") |             |

##### Generic Types

| Name    | Description |
| ------- | ----------- |
| T       |             |
| TSource |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IError}-'></a>

### AddErrors\`\`1(result,errors) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                                                                                                                                             | Description |
| ------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")                                                                                                                             |             |
| errors | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IError}") |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddErrors``2-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Interfaces-IResult{``1}-'></a>

### AddErrors\`\`2(destination,source) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name        | Type                                                                                                                                                 | Description |
| ----------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| destination | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| source      | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`1}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``1} "RSM.HCD.CSharp.Core.Interfaces.IResult{``1}") |             |

##### Generic Types

| Name    | Description |
| ------- | ----------- |
| T       |             |
| TSource |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddExceptionError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-Exception-'></a>

### AddExceptionError\`\`1(result,key,exception) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                 | Description |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| key       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception "System.Exception")                     |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddNextLinkParam``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-String-'></a>

### AddNextLinkParam\`\`1(result,key,value) `method`

##### Summary

Adds a new key value pair to the NextLinkParams. Essentially saves needing to
null check and externally manage NextLinkParams property directly.

##### Returns

Reference to NextLinkParams

##### Parameters

| Name   | Type                                                                                                                                                 | Description                            |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |                                        |
| key    | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              | Unique key to add for next link params |
| value  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              | Value for supplied key. Can be null    |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddNextLinkParam``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-Int32-'></a>

### AddNextLinkParam\`\`1(result,key,value) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                 | Description |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| key    | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |
| value  | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 "System.Int32")                                 |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddNextLinkParams``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Interfaces-IResult{``0}-'></a>

### AddNextLinkParams\`\`1(destinationResult,sourceResult) `method`

##### Summary

Adds NextLinkParams key value pairs from a source IResult to a destination IResult.

The destination result's NextLinkParams dictionary reference will remain unchanged.

##### Returns

Reference to NextLinkParams

##### Parameters

| Name              | Type                                                                                                                                                 | Description                                              |
| ----------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------- |
| destinationResult | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") | IResult destination to which next link params are copied |
| sourceResult      | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") | IResult source from which to copy next link params       |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddValidationError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String,System-String-'></a>

### AddValidationError\`\`1(result,key,message) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name    | Type                                                                                                                                                 | Description |
| ------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result  | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| key     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-AddValidationError``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Object[]-'></a>

### AddValidationError\`\`1(result,localizer,key,arguments) `method`

##### Summary

Add translated error record of type Validation

##### Parameters

| Name      | Type                                                                                                                                                             | Description                                                  |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}")             |                                                              |
| localizer | [Microsoft.Extensions.Localization.IStringLocalizer](#T-Microsoft-Extensions-Localization-IStringLocalizer "Microsoft.Extensions.Localization.IStringLocalizer") |                                                              |
| key       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                          | Error key found in culture files                             |
| arguments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] "System.Object[]")                                    | The values with which to format the translated error message |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-DoesNotHaveErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>

### DoesNotHaveErrors\`\`1(result,errorType) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                 | Description |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| errorType | [RSM.HCD.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType "RSM.HCD.CSharp.Core.Enumerations.ErrorType")      |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-DoesNotHaveErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String-'></a>

### DoesNotHaveErrors\`\`1(result,key) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                 | Description |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| key    | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-GetErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>

### GetErrors\`\`1(result,errorType) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                 | Description |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| errorType | [RSM.HCD.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType "RSM.HCD.CSharp.Core.Enumerations.ErrorType")      |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-GetErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String-'></a>

### GetErrors\`\`1(result,key) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                 | Description |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| key    | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-GetValidationErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0}-'></a>

### GetValidationErrors\`\`1(result) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                 | Description |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrorsOrResultIsFalse-AndcultureCode-CSharp-Core-Interfaces-IResult{System-Boolean}-'></a>

### HasErrorsOrResultIsFalse(result) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                                                | Description |
| ------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{System.Boolean}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{System-Boolean} "RSM.HCD.CSharp.Core.Interfaces.IResult{System.Boolean}") |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrorsOrResultIsNull``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0}-'></a>

### HasErrorsOrResultIsNull\`\`1(result) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                 | Description |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IResult{``0}},AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>

### HasErrors\`\`1(resultList,errorType) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                                                                                           | Description |
| ---------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| resultList | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{``0}}") |
| errorType  | [RSM.HCD.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType "RSM.HCD.CSharp.Core.Enumerations.ErrorType")                                                                                                                                                |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IResult{``0}},System-String-'></a>

### HasErrors\`\`1(resultList,key) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                                                                                           | Description |
| ---------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| resultList | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{``0}}") |
| key        | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                        |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IResult{``0}}-'></a>

### HasErrors\`\`1(resultList) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                                                                                           | Description |
| ---------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| resultList | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{``0}}") |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},AndcultureCode-CSharp-Core-Enumerations-ErrorType-'></a>

### HasErrors\`\`1(result,errorType) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                 | Description |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| errorType | [RSM.HCD.CSharp.Core.Enumerations.ErrorType](#T-AndcultureCode-CSharp-Core-Enumerations-ErrorType "RSM.HCD.CSharp.Core.Enumerations.ErrorType")      |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String-'></a>

### HasErrors\`\`1(result,key) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                 | Description |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| key    | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-HasValidationErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0}-'></a>

### HasValidationErrors\`\`1(result) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name   | Type                                                                                                                                                 | Description |
| ------ | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ListErrors``1-System-Collections-Generic-IEnumerable{AndcultureCode-CSharp-Core-Interfaces-IResult{``0}},System-String-'></a>

### ListErrors\`\`1(resultList,delimiter) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                                                                                           | Description |
| ---------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| resultList | [System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{RSM.HCD.CSharp.Core.Interfaces.IResult{``0}}") |
| delimiter  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                                                                        |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ListErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-String-'></a>

### ListErrors\`\`1(result,delimiter) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                 | Description |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result    | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                              |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ThrowIfAnyErrorsOrResultIsFalse-AndcultureCode-CSharp-Core-Interfaces-IResult{System-Boolean},System-Exception,System-Exception-'></a>

### ThrowIfAnyErrorsOrResultIsFalse(result,hasErrorsException,resultNullException) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name                | Type                                                                                                                                                                                | Description |
| ------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result              | [RSM.HCD.CSharp.Core.Interfaces.IResult{System.Boolean}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{System-Boolean} "RSM.HCD.CSharp.Core.Interfaces.IResult{System.Boolean}") |             |
| hasErrorsException  | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception "System.Exception")                                                    |             |
| resultNullException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception "System.Exception")                                                    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ThrowIfAnyErrorsOrResultIsNull``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-Exception,System-Exception-'></a>

### ThrowIfAnyErrorsOrResultIsNull\`\`1(result,hasErrorsException,resultNullException) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name                | Type                                                                                                                                                 | Description |
| ------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result              | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| hasErrorsException  | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception "System.Exception")                     |             |
| resultNullException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception "System.Exception")                     |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-IResultExtensions-ThrowIfAnyErrors``1-AndcultureCode-CSharp-Core-Interfaces-IResult{``0},System-Exception-'></a>

### ThrowIfAnyErrors\`\`1(result,customException) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name            | Type                                                                                                                                                 | Description |
| --------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| result          | [RSM.HCD.CSharp.Core.Interfaces.IResult{\`\`0}](#T-AndcultureCode-CSharp-Core-Interfaces-IResult{``0} "RSM.HCD.CSharp.Core.Interfaces.IResult{``0}") |             |
| customException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception "System.Exception")                     |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-IResult`1'></a>

## IResult\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces

<a name='P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-ErrorCount'></a>

### ErrorCount `property`

##### Summary

Number of errors

<a name='P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-Errors'></a>

### Errors `property`

##### Summary

List of errors around a request

<a name='P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-HasErrors'></a>

### HasErrors `property`

##### Summary

Does this result contain any errors?

<a name='P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-NextLinkParams'></a>

### NextLinkParams `property`

##### Summary

List of key value pairs to be used request the very next related Result

<a name='P-AndcultureCode-CSharp-Core-Interfaces-IResult`1-ResultObject'></a>

### ResultObject `property`

##### Summary

Actual resulting value from the request

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Entity-IRole'></a>

## IRole `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Entity

##### Summary

Unique reponsibility (typically of a user) in the system

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IRole-Description'></a>

### Description `property`

##### Summary

Brief description around the purpose of this role in the system

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IRole-Name'></a>

### Name `property`

##### Summary

Human readable name for this role in the system
///

<a name='T-AndcultureCode-CSharp-Core-Extensions-IServiceCollectionExtensions'></a>

## IServiceCollectionExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

Convenience extensions for registering/configuring core actors
///

<a name='M-AndcultureCode-CSharp-Core-Extensions-IServiceCollectionExtensions-AddSeeding-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfigurationRoot-'></a>

### AddSeeding(services,configuration) `method`

##### Summary

Configure application to support data seeding

##### Returns

##### Parameters

| Name          | Type                                                                                                                                                                                        | Description |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| services      | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection "Microsoft.Extensions.DependencyInjection.IServiceCollection") |             |
| configuration | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot "Microsoft.Extensions.Configuration.IConfigurationRoot")                   |             |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider'></a>

## IStorageProvider `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Providers.Storage

##### Summary

Generic storage container provider

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-Copy-System-String,System-String,System-String,System-String,System-String,System-String-'></a>

### Copy(srcRelativeProviderPath,srcStorageContainer,destRelativeProviderPath,destStorageContainer,srcPathToCopy,destPathToCopy) `method`

##### Summary

Copies a file or folder from a source location on the external storage provider to a
destination location on the external storage provider.

##### Returns

True if the copy operation succeeded, false otherwise.

##### Parameters

| Name                                                                              | Type                                                                                                                    | Description                                                                                 |
| --------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| srcRelativeProviderPath                                                           | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Name of the 'prefix' or relative path under the source bucket to copy data from             |
| srcStorageContainer                                                               | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Name of the source bucket/container from which to pull data from                            |
| destRelativeProviderPath                                                          | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Name of the 'prefix' or relative path under the destination bucket to copy data to          |
| destStorageContainer                                                              | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Name of the destination bucket/container from which to copy data to                         |
| srcPathToCopy                                                                     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | (Optional) Name of the individual file underneath the source bucket and relative path.      |
| If omitted, it is assumed you are copying a folder instead of an individual file. |
| destPathToCopy                                                                    | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | (Optional) Name of the individual file underneath the destination bucket and relative path. |
| If omitted, it is assumed you are copying a folder instead of an individual file. |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-Download-System-String,System-String,System-String-'></a>

### Download(relativeProviderPath,storageContainer,pathToSave) `method`

##### Summary

Downloads and saves file from external storage to local machine

##### Parameters

| Name                 | Type                                                                                                                    | Description                                         |
| -------------------- | ----------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------- |
| relativeProviderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Path to file respective to the parent folder/bucket |
| storageContainer     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Parent level folder/bucket                          |
| pathToSave           | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Path on local system to save file                   |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-FileExists-System-String,System-String-'></a>

### FileExists(relativeProviderPath,storageContainer) `method`

##### Summary

Check existence of a file stored externally

##### Parameters

| Name                 | Type                                                                                                                    | Description                                         |
| -------------------- | ----------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------- |
| relativeProviderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Path to file respective to the parent folder/bucket |
| storageContainer     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Parent level folder/bucket                          |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-GetFile-System-String,System-String-'></a>

### GetFile(relativeProviderPath,storageContainer) `method`

##### Summary

Get's file contents from storage provider

##### Parameters

| Name                 | Type                                                                                                                    | Description                                         |
| -------------------- | ----------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------- |
| relativeProviderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Path to file respective to the parent folder/bucket |
| storageContainer     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | Parent level folder/bucket                          |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Storage-IStorageProvider-GetRemoteAccessDetails-System-String,System-String,System-Nullable{System-DateTimeOffset},AndcultureCode-CSharp-Core-Enumerations-HttpVerb,System-String-'></a>

### GetRemoteAccessDetails(relativeProviderPath,storageContainer,expiryTime,httpVerb,contentType) `method`

##### Summary

Get resource RemoteAccessDetails

##### Parameters

| Name                 | Type                                                                                                                                                                        | Description                                         |
| -------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------- |
| relativeProviderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                     | Path to file respective to the parent folder/bucket |
| storageContainer     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                     | Parent level folder/bucket                          |
| expiryTime           | [System.Nullable{System.DateTimeOffset}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable "System.Nullable{System.DateTimeOffset}") | Life span before exipiration                        |
| httpVerb             | [RSM.HCD.CSharp.Core.Enumerations.HttpVerb](#T-AndcultureCode-CSharp-Core-Enumerations-HttpVerb "RSM.HCD.CSharp.Core.Enumerations.HttpVerb")                                | The Http verb of requested action                   |
| contentType          | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                     | Content-Type of requested resource                  |

<a name='T-AndcultureCode-CSharp-Core-Extensions-IStringLocalizerExtensions'></a>

## IStringLocalizerExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

<a name='M-AndcultureCode-CSharp-Core-Extensions-IStringLocalizerExtensions-Default-Microsoft-Extensions-Localization-IStringLocalizer,System-String,System-Object[]-'></a>

### Default(localizer,key,arguments) `method`

##### Summary

Retrieve given translation for default configured culture

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                             | Description                                                  |
| --------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| localizer | [Microsoft.Extensions.Localization.IStringLocalizer](#T-Microsoft-Extensions-Localization-IStringLocalizer "Microsoft.Extensions.Localization.IStringLocalizer") |                                                              |
| key       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                          |                                                              |
| arguments | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] "System.Object[]")                                    | The values with which to format the translated error message |

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser'></a>

## IUser `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Entity

##### Summary

Descriptor of an individual in the system

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-Email'></a>

### Email `property`

##### Summary

Email address

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-FirstName'></a>

### FirstName `property`

##### Summary

First name

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-IsSuperAdmin'></a>

### IsSuperAdmin `property`

##### Summary

Highest level user permission.
Has access to all capabilities in the system.

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-LastName'></a>

### LastName `property`

##### Summary

Last name

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-PasswordHash'></a>

### PasswordHash `property`

##### Summary

Encrypted base64 password

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-Salt'></a>

### Salt `property`

##### Summary

Base64 salt

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-SecurityStamp'></a>

### SecurityStamp `property`

##### Summary

Idenitifer used to compare changes to this "identity".
Can take on many forms depending upon the application (ie. datetime, guid)

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUser-UserName'></a>

### UserName `property`

##### Summary

Alias/handle in the system

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin'></a>

## IUserLogin `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Entity

##### Summary

Captures a given user's attempts at both
successfully and unsuccessfully log into the system.

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-FailedAttemptCount'></a>

### FailedAttemptCount `property`

##### Summary

Number of consecutive failed attempts at logging in

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-Ip'></a>

### Ip `property`

##### Summary

IP address of requests to authenticate this user

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-IsSuccessful'></a>

### IsSuccessful `property`

##### Summary

Is this a successful login request?

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-Role'></a>

### Role `property`

##### Summary

Reference to IRole that has Id equal to RoleId

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-RoleId'></a>

### RoleId `property`

##### Summary

Unique identifier of associated IRole

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-ServerName'></a>

### ServerName `property`

##### Summary

Identifier (hopefully unique) of server handling the request

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-User'></a>

### User `property`

##### Summary

Reference to IUser that has an Id equal to UserId

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-UserAgent'></a>

### UserAgent `property`

##### Summary

Requesting party's user-agent

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-UserId'></a>

### UserId `property`

##### Summary

Unique identifier of associated IUser

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserLogin-UserName'></a>

### UserName `property`

##### Summary

Handle/Alias used to login (or attempt to login) this user

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata'></a>

## IUserMetadata `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Entity

##### Summary

Describes an individual user/role setting

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-IsNameEditable'></a>

### IsNameEditable `property`

##### Summary

Can the name of this object be changed? (if not, system likely relies on it)

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-Name'></a>

### Name `property`

##### Summary

Name for metadata

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-Role'></a>

### Role `property`

##### Summary

Reference to IRole that has Id equal to RoleId

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-RoleId'></a>

### RoleId `property`

##### Summary

Unique identifier of associated IRole

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-Type'></a>

### Type `property`

##### Summary

Type classification for metadata

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-User'></a>

### User `property`

##### Summary

Reference to IUser that has an Id equal to UserId

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-UserId'></a>

### UserId `property`

##### Summary

Unique identifier of associated IUser

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserMetadata-Value'></a>

### Value `property`

##### Summary

User's value for this setting

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole'></a>

## IUserRole `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Entity

##### Summary

Associates a role to a user

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole-Role'></a>

### Role `property`

##### Summary

Reference to IRole that has Id equal to RoleId

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole-RoleId'></a>

### RoleId `property`

##### Summary

Unique identifier of associated IRole

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole-User'></a>

### User `property`

##### Summary

Reference to IUser that has an Id equal to UserId

<a name='P-AndcultureCode-CSharp-Core-Interfaces-Entity-IUserRole-UserId'></a>

### UserId `property`

##### Summary

Unique identifier of associated IUser

<a name='T-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider'></a>

## IWorkerProvider `type`

##### Namespace

RSM.HCD.CSharp.Core.Interfaces.Providers.Worker

##### Summary

Background job processing provider

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Delete-System-String-'></a>

### Delete(id) `method`

##### Summary

Changes the state of an enqueued job to deleted. Will still be counted in the EnqueuedCount

##### Returns

##### Parameters

| Name | Type                                                                                                                    | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| id   | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-DeletedCount'></a>

### DeletedCount() `method`

##### Summary

Number of jobs in the deleted state.

##### Returns

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Enqueue-System-Linq-Expressions-Expression{System-Action}-'></a>

### Enqueue(methodCall) `method`

##### Summary

Create a new fire and forget worker task

##### Parameters

| Name       | Type                                                                                                                                                                                                                 | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action}") |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Enqueue``1-System-Linq-Expressions-Expression{System-Action{``0}}-'></a>

### Enqueue\`\`1(methodCall) `method`

##### Summary

Create a new fire and forget worker task

##### Parameters

| Name       | Type                                                                                                                                                                                                                             | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-EnqueuedCount-System-String-'></a>

### EnqueuedCount(queue) `method`

##### Summary

Enqueued can still mean deleted. This includes all jobs enqueued regardless of state.

##### Returns

##### Parameters

| Name  | Type                                                                                                                    | Description |
| ----- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| queue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Recur-System-String,System-Linq-Expressions-Expression{System-Action},AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-'></a>

### Recur(identifier,methodCall,recurringOptions) `method`

##### Summary

Create a recurring worker task

##### Parameters

| Name             | Type                                                                                                                                                                                                                 | Description |
| ---------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| identifier       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                              |             |
| methodCall       | [System.Linq.Expressions.Expression{System.Action}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action}") |             |
| recurringOptions | [RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption](#T-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption")                      |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Recur``1-System-String,System-Linq-Expressions-Expression{System-Action{``0}},System-String-'></a>

### Recur\`\`1(identifier,methodCall,chronExpression) `method`

##### Summary

Create a recurring worker task

##### Parameters

| Name            | Type                                                                                                                                                                                                                             | Description |
| --------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| identifier      | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                          |             |
| methodCall      | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |
| chronExpression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                          |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Recur``1-System-String,System-Linq-Expressions-Expression{System-Action{``0}},AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-'></a>

### Recur\`\`1(identifier,methodCall,recurringOptions) `method`

##### Summary

Create a recurring worker task

##### Parameters

| Name             | Type                                                                                                                                                                                                                             | Description |
| ---------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| identifier       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                          |             |
| methodCall       | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |
| recurringOptions | [RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption](#T-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption")                                  |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-RecurringCount'></a>

### RecurringCount() `method`

##### Summary

Number of jobs that have been setup for recurrence.

##### Returns

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-RemoveRecurrence-System-String-'></a>

### RemoveRecurrence(identifier) `method`

##### Summary

Remove a worker recurrence

##### Parameters

| Name       | Type                                                                                                                    | Description |
| ---------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| identifier | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Schedule-System-Linq-Expressions-Expression{System-Action},System-TimeSpan-'></a>

### Schedule(methodCall,delay) `method`

##### Summary

Schedule a method to be enqueued at a specific time

##### Parameters

| Name       | Type                                                                                                                                                                                                                 | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action}") |             |
| delay      | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan "System.TimeSpan")                                                                                        |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Schedule-System-Linq-Expressions-Expression{System-Action},System-DateTimeOffset-'></a>

### Schedule(methodCall,enqueueOn) `method`

##### Summary

Schedule a method to be enqueued at a specific time

##### Parameters

| Name       | Type                                                                                                                                                                                                                 | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action}") |             |
| enqueueOn  | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset "System.DateTimeOffset")                                                                      |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Schedule``1-System-Linq-Expressions-Expression{System-Action{``0}},System-TimeSpan-'></a>

### Schedule\`\`1(methodCall,delay) `method`

##### Summary

Schedule a method to be enqueued at a specific time

##### Parameters

| Name       | Type                                                                                                                                                                                                                             | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |
| delay      | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan "System.TimeSpan")                                                                                                    |             |

<a name='M-AndcultureCode-CSharp-Core-Interfaces-Providers-Worker-IWorkerProvider-Schedule``1-System-Linq-Expressions-Expression{System-Action{``0}},System-DateTimeOffset-'></a>

### Schedule\`\`1(methodCall,enqueueOn) `method`

##### Summary

Schedule a method to be enqueued at a specific time

##### Parameters

| Name       | Type                                                                                                                                                                                                                             | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |
| enqueueOn  | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset "System.DateTimeOffset")                                                                                  |             |

<a name='T-AndcultureCode-CSharp-Core-Enumerations-JobStatus'></a>

## JobStatus `type`

##### Namespace

RSM.HCD.CSharp.Core.Enumerations

##### Summary

Statuses for a given job

<a name='T-AndcultureCode-CSharp-Core-Providers-Configuration-LocalConfigurationProvider'></a>

## LocalConfigurationProvider `type`

##### Namespace

RSM.HCD.CSharp.Core.Providers.Configuration

##### Summary

Centralized location for loading configuration settings

<a name='M-AndcultureCode-CSharp-Core-Providers-Configuration-LocalConfigurationProvider-#ctor-System-String-'></a>

### #ctor(basePath) `constructor`

##### Summary

Constructor

##### Parameters

| Name     | Type                                                                                                                    | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| basePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Configuration-LocalConfigurationProvider-GetConfiguration'></a>

### GetConfiguration() `method`

##### Summary

Constructs configuration object

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils'></a>

## LocalizationUtils `type`

##### Namespace

RSM.HCD.CSharp.Core.Utilities.Localization

##### Summary

Static class with helper functions related to localization

<a name='P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-CultureInfos'></a>

### CultureInfos `property`

##### Summary

List of supported CultureInfo

<a name='P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-Cultures'></a>

### Cultures `property`

##### Summary

Current cultures supported by the application

<a name='P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-DefaultCulture'></a>

### DefaultCulture `property`

##### Summary

Default culture for the application

<a name='P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-DefaultCultureCode'></a>

### DefaultCultureCode `property`

##### Summary

Code of the default culture for the application

<a name='P-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-DefaultCultureInfo'></a>

### DefaultCultureInfo `property`

##### Summary

CultureInfo of the default culture fore the application

<a name='M-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-CultureByCode-System-String-'></a>

### CultureByCode(cultureCode) `method`

##### Summary

Retrieves the [ICulture](#T-AndcultureCode-CSharp-Core-Interfaces-ICulture "RSM.HCD.CSharp.Core.Interfaces.ICulture") from the supported Cultures by `cultureCode`

##### Returns

##### Parameters

| Name        | Type                                                                                                                    | Description |
| ----------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| cultureCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-CultureCodes-System-String-'></a>

### CultureCodes(delimiter) `method`

##### Summary

Retrieves the codes of the current cultures supported by the application

##### Returns

A concatenated string delimited by `delimiter`

##### Parameters

| Name      | Type                                                                                                                    | Description |
| --------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| delimiter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Utilities-Localization-LocalizationUtils-CultureExists-System-String-'></a>

### CultureExists(cultureCode) `method`

##### Summary

Checks if a culture by the given `cultureCode` is supported by the application

##### Returns

##### Parameters

| Name        | Type                                                                                                                    | Description                                  |
| ----------- | ----------------------------------------------------------------------------------------------------------------------- | -------------------------------------------- |
| cultureCode | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | The string identifying the requested culture |

<a name='T-AndcultureCode-CSharp-Core-Models-Lockable'></a>

## Lockable `type`

##### Namespace

RSM.HCD.CSharp.Core.Models

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Lockable-IsLocked'></a>

### IsLocked `property`

##### Summary

Calculated field based on if LockedUntil (when not null) is in the past or future.

<a name='P-AndcultureCode-CSharp-Core-Models-Lockable-LockedById'></a>

### LockedById `property`

##### Summary

The identifier of the user who locked the record

<a name='P-AndcultureCode-CSharp-Core-Models-Lockable-LockedOn'></a>

### LockedOn `property`

##### Summary

The date and time of when the record was locked

<a name='P-AndcultureCode-CSharp-Core-Models-Lockable-LockedUntil'></a>

### LockedUntil `property`

##### Summary

The date and time for when the record will stop being locked

<a name='M-AndcultureCode-CSharp-Core-Models-Lockable-DetermineIfLocked'></a>

### DetermineIfLocked() `method`

##### Summary

A record is considered "locked" if the LockedUntil field is not null
and is set to a time in the future

##### Returns

true if LockedUntil is not null and is set to a time in the future, false otherwise

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Enumerations-LogicalOperator'></a>

## LogicalOperator `type`

##### Namespace

RSM.HCD.CSharp.Core.Enumerations

##### Summary

Simple Bitwise enumeration

<a name='T-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration'></a>

## OAuthAccountConfiguration `type`

##### Namespace

RSM.HCD.CSharp.Business.Core.Models.Configuration

##### Summary

Describes common configuration for OAuth providers

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration-ClientId'></a>

### ClientId `property`

##### Summary

Application's uniquely assigned Id

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration-ClientSecret'></a>

### ClientSecret `property`

##### Summary

Application's uniquely assigned Secret

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration-IsDisabled'></a>

### IsDisabled `property`

##### Summary

Is this integration disabled?

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-OAuthAccountConfiguration-IsEnabled'></a>

### IsEnabled `property`

##### Summary

Is this integration enabled?

<a name='T-AndcultureCode-CSharp-Core-Extensions-ObjectExtensions'></a>

## ObjectExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

TODO: Extract to RSM.HCD.CSharp.Extensions project
https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/64

<a name='M-AndcultureCode-CSharp-Core-Extensions-ObjectExtensions-FromByteArray``1-System-Byte[]-'></a>

### FromByteArray\`\`1() `method`

##### Summary

Converts supplied byte array to requested type

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-ObjectExtensions-ToByteArray-System-Object-'></a>

### ToByteArray(obj) `method`

##### Summary

Converts supplied data to byte array

##### Returns

##### Parameters

| Name | Type                                                                                                                    | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| obj  | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object "System.Object") |             |

<a name='T-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2'></a>

## OrderedList\`2 `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Collections

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Generic Types

| Name   | Description |
| ------ | ----------- |
| TKey   |             |
| TValue |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-#ctor'></a>

### #ctor() `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

This constructor has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-#ctor-System-Collections-Generic-IComparer{`0}-'></a>

### #ctor(comparer) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name     | Type                                                                                                                                                                                                  | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| comparer | [System.Collections.Generic.IComparer{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer "System.Collections.Generic.IComparer{`0}") |

<a name='P-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Count'></a>

### Count `property`

##### Summary

Returns a count of items in the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 "System.Collections.Generic.ICollection`1").

<a name='P-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-IsReadOnly'></a>

### IsReadOnly `property`

##### Summary

Returns a value indicating if the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 "System.Collections.Generic.ICollection`1") is read-only.

<a name='P-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Item-`0-'></a>

### Item `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name | Type              | Description |
| ---- | ----------------- | ----------- |
| key  | [\`0](#T-`0 "`0") |             |

<a name='P-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Keys'></a>

### Keys `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Add-`0,`1-'></a>

### Add(key,value) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name  | Type              | Description |
| ----- | ----------------- | ----------- |
| key   | [\`0](#T-`0 "`0") |             |
| value | [\`1](#T-`1 "`1") |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Clear'></a>

### Clear() `method`

##### Summary

Removes all items from the [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 "System.Collections.Generic.ICollection`1").

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-ContainsKey-`0-'></a>

### ContainsKey(key) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Returns

##### Parameters

| Name | Type              | Description |
| ---- | ----------------- | ----------- |
| key  | [\`0](#T-`0 "`0") |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-GetEnumerator'></a>

### GetEnumerator() `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Returns

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-Remove-`0,`1-'></a>

### Remove(key,value) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name  | Type              | Description |
| ----- | ----------------- | ----------- |
| key   | [\`0](#T-`0 "`0") |             |
| value | [\`1](#T-`1 "`1") |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-OrderedList`2-TryGetValue-`0,System-Collections-Generic-ICollection{`1}@-'></a>

### TryGetValue(key,value) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Returns

##### Parameters

| Name  | Type                                                                                                                                                                                                          | Description |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| key   | [\`0](#T-`0 "`0")                                                                                                                                                                                             |             |
| value | [System.Collections.Generic.ICollection{\`1}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection "System.Collections.Generic.ICollection{`1}@") |

<a name='T-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1'></a>

## PagedResult\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Errors

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-#ctor-`0,System-Int64-'></a>

### #ctor(rows,rowCount) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name     | Type                                                                                                                 | Description |
| -------- | -------------------------------------------------------------------------------------------------------------------- | ----------- |
| rows     | [\`0](#T-`0 "`0")                                                                                                    |             |
| rowCount | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64") |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-#ctor-`0,System-Int64,System-Collections-Generic-Dictionary{System-String,System-String}-'></a>

### #ctor(rows,rowCount,nextLinkParams) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name           | Type                                                                                                                                                                                                                                                      | Description |
| -------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| rows           | [\`0](#T-`0 "`0")                                                                                                                                                                                                                                         |             |
| rowCount       | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 "System.Int64")                                                                                                                                      |             |
| nextLinkParams | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary "System.Collections.Generic.Dictionary{System.String,System.String}") |             |

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-ErrorCount'></a>

### ErrorCount `property`

##### Summary

Gets the number of errors, if there are any; otherwise, returns 0.

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-Errors'></a>

### Errors `property`

##### Summary

List of errors around a request

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-HasErrors'></a>

### HasErrors `property`

##### Summary

Returns whether or not this result has any errors

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-NextLinkParams'></a>

### NextLinkParams `property`

##### Summary

List of key value pairs to be used request the very next related Result

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-ResultObject'></a>

### ResultObject `property`

##### Summary

Actual resulting value from the request

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-PagedResult`1-RowCount'></a>

### RowCount `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='T-AndcultureCode-CSharp-Core-Providers-Provider'></a>

## Provider `type`

##### Namespace

RSM.HCD.CSharp.Core.Providers

##### Summary

Base implementation for Providers

<a name='P-AndcultureCode-CSharp-Core-Providers-Provider-Implemented'></a>

### Implemented `property`

##### Summary

Specify whether the provider has been implemented

<a name='P-AndcultureCode-CSharp-Core-Providers-Provider-Name'></a>

### Name `property`

##### Summary

Name of the provider

<a name='T-AndcultureCode-CSharp-Core-Constants-Queue'></a>

## Queue `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Constants class to hold identifiers for a queue concept

<a name='F-AndcultureCode-CSharp-Core-Constants-Queue-ALL'></a>

### ALL `constants`

##### Summary

Easy to access array of all queues in priority order from highest to lowest

<a name='F-AndcultureCode-CSharp-Core-Constants-Queue-DEFAULT'></a>

### DEFAULT `constants`

##### Summary

The default queue, general purpose that should happen relatively soon. Say a few minutes, but the world won't end
if it happens to be delayed.

<a name='T-AndcultureCode-CSharp-Core-Enumerations-Recurrence'></a>

## Recurrence `type`

##### Namespace

RSM.HCD.CSharp.Core.Enumerations

##### Summary

Different types of job recurrence

<a name='T-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption'></a>

## RecurringOption `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Entities.Worker

##### Summary

Recurrence configuration for a given worker

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Day'></a>

### Day `property`

##### Summary

Integer representation of the day

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-DayOfWeek'></a>

### DayOfWeek `property`

##### Summary

Specifies the day of the week

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Hour'></a>

### Hour `property`

##### Summary

Integer representation of the hour

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Minute'></a>

### Minute `property`

##### Summary

Integer representation of the minute

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Month'></a>

### Month `property`

##### Summary

Integer representation of the month

<a name='P-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-Recurrence'></a>

### Recurrence `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='T-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb'></a>

## ResourceVerb `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Security

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='M-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-#ctor-System-String,System-String-'></a>

### #ctor(resource,verb) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name     | Type                                                                                                                    | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| resource | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| verb     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-#ctor-System-String-'></a>

### #ctor(resourceVerb) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name         | Type                                                                                                                    | Description |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| resourceVerb | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

##### Exceptions

| Name                                                                                                                                                     | Description |
| -------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException "System.ArgumentException") |             |

<a name='P-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-Resource'></a>

### Resource `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='P-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-Verb'></a>

### Verb `property`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

<a name='M-AndcultureCode-CSharp-Core-Models-Security-ResourceVerb-ToString'></a>

### ToString() `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Returns

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Extensions-ResourceVerbExtensions'></a>

## ResourceVerbExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

<a name='M-AndcultureCode-CSharp-Core-Extensions-ResourceVerbExtensions-ToResourceVerb-System-String-'></a>

### ToResourceVerb(resourceVerbString) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name               | Type                                                                                                                    | Description |
| ------------------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| resourceVerbString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Extensions-ResourceVerbExtensions-ToResourceVerbs-System-Collections-Generic-IEnumerable{System-String}-'></a>

### ToResourceVerbs(resourceVerbStrings) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/37

##### Returns

##### Parameters

| Name                | Type                                                                                                                                                                                                                             | Description |
| ------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| resourceVerbStrings | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable "System.Collections.Generic.IEnumerable{System.String}") |             |

<a name='T-AndcultureCode-CSharp-Core-Models-Errors-Result`1'></a>

## Result\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Errors

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Errors-Result`1-#ctor'></a>

### #ctor() `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

This constructor has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Models-Errors-Result`1-#ctor-System-String-'></a>

### #ctor(errorMessage) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name         | Type                                                                                                                    | Description |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Errors-Result`1-#ctor-System-String,System-String-'></a>

### #ctor(errorKey,errorMessage) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name         | Type                                                                                                                    | Description |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| errorKey     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Errors-Result`1-#ctor-`0-'></a>

### #ctor(resultObject) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name         | Type              | Description |
| ------------ | ----------------- | ----------- |
| resultObject | [\`0](#T-`0 "`0") |             |

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-ErrorCount'></a>

### ErrorCount `property`

##### Summary

Gets the number of errors, if there are any; otherwise, returns 0.

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-Errors'></a>

### Errors `property`

##### Summary

List of errors around a request

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-HasErrors'></a>

### HasErrors `property`

##### Summary

Returns whether or not this result has any error

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-NextLinkParams'></a>

### NextLinkParams `property`

##### Summary

List of key value pairs to be used request the very next related Result

<a name='P-AndcultureCode-CSharp-Core-Models-Errors-Result`1-ResultObject'></a>

### ResultObject `property`

##### Summary

Actual resulting value from the request

<a name='T-AndcultureCode-CSharp-Core-Models-Collections-ReverseComparer`1'></a>

## ReverseComparer\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core.Models.Collections

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TKey |             |

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-ReverseComparer`1-#ctor'></a>

### #ctor() `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

This constructor has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-ReverseComparer`1-#ctor-System-Collections-Generic-IComparer{`0}-'></a>

### #ctor(comparer) `constructor`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Parameters

| Name     | Type                                                                                                                                                                                                  | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| comparer | [System.Collections.Generic.IComparer{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IComparer "System.Collections.Generic.IComparer{`0}") |

<a name='M-AndcultureCode-CSharp-Core-Models-Collections-ReverseComparer`1-Compare-`0,`0-'></a>

### Compare(x,y) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/38

##### Returns

##### Parameters

| Name | Type              | Description |
| ---- | ----------------- | ----------- |
| x    | [\`0](#T-`0 "`0") |             |
| y    | [\`0](#T-`0 "`0") |             |

<a name='T-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes'></a>

## Rfc4646LanguageCodes `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

RFC-4646 Language Codes
See https://docs.microsoft.com/en-us/previous-versions/commerce-server/ee825488(v=cs.20)?redirectedfrom=MSDN

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AF_ZA'></a>

### AF_ZA `constants`

##### Summary

Afrikaans - South Africa

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_AE'></a>

### AR_AE `constants`

##### Summary

Arabic - United Arab Emirates

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_BH'></a>

### AR_BH `constants`

##### Summary

Arabic - Bahrain

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_DZ'></a>

### AR_DZ `constants`

##### Summary

Arabic - Algeria

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_EG'></a>

### AR_EG `constants`

##### Summary

Arabic - Egypt

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_IQ'></a>

### AR_IQ `constants`

##### Summary

Arabic - Iraq

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_JO'></a>

### AR_JO `constants`

##### Summary

Arabic - Jordan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_KW'></a>

### AR_KW `constants`

##### Summary

Arabic - Kuwait

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_LB'></a>

### AR_LB `constants`

##### Summary

Arabic - Lebanon

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_LY'></a>

### AR_LY `constants`

##### Summary

Arabic - Libya

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_MA'></a>

### AR_MA `constants`

##### Summary

Arabic - Morocco

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_OM'></a>

### AR_OM `constants`

##### Summary

Arabic - Oman

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_QA'></a>

### AR_QA `constants`

##### Summary

Arabic - Qatar

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_SA'></a>

### AR_SA `constants`

##### Summary

Arabic - Saudi Arabia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_SY'></a>

### AR_SY `constants`

##### Summary

Arabic - Syria

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_TN'></a>

### AR_TN `constants`

##### Summary

Arabic - Tunisia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-AR_YE'></a>

### AR_YE `constants`

##### Summary

Arabic - Yemen

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-BE_BY'></a>

### BE_BY `constants`

##### Summary

Belarusian - Belarus

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-BG_BG'></a>

### BG_BG `constants`

##### Summary

Bulgarian - Bulgaria

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CA_ES'></a>

### CA_ES `constants`

##### Summary

Catalan - Catalan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CS_CZ'></a>

### CS_CZ `constants`

##### Summary

Czech - Czech Republic

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CY_AZ_AZ'></a>

### CY_AZ_AZ `constants`

##### Summary

Azeri (Cyrillic) - Azerbaijan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CY_SR_SP'></a>

### CY_SR_SP `constants`

##### Summary

Serbian (Cyrillic) - Serbia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-CY_UZ_UZ'></a>

### CY_UZ_UZ `constants`

##### Summary

Uzbek (Cyrillic) - Uzbekistan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DA_DK'></a>

### DA_DK `constants`

##### Summary

Danish - Denmark

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_AT'></a>

### DE_AT `constants`

##### Summary

German - Austria

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_CH'></a>

### DE_CH `constants`

##### Summary

German - Switzerland

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_DE'></a>

### DE_DE `constants`

##### Summary

German - Germany

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_LI'></a>

### DE_LI `constants`

##### Summary

German - Liechtenstein

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DE_LU'></a>

### DE_LU `constants`

##### Summary

German - Luxembourg

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-DIV_MV'></a>

### DIV_MV `constants`

##### Summary

Dhivehi - Maldives

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EL_GR'></a>

### EL_GR `constants`

##### Summary

Greek - Greece

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_AU'></a>

### EN_AU `constants`

##### Summary

English - Australia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_BZ'></a>

### EN_BZ `constants`

##### Summary

English - Belize

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_CA'></a>

### EN_CA `constants`

##### Summary

English - Canada

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_CB'></a>

### EN_CB `constants`

##### Summary

English - Caribbean

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_GB'></a>

### EN_GB `constants`

##### Summary

English - United Kingdom

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_IE'></a>

### EN_IE `constants`

##### Summary

English - Ireland

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_JM'></a>

### EN_JM `constants`

##### Summary

English - Jamaica

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_NZ'></a>

### EN_NZ `constants`

##### Summary

English - New Zealand

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_PH'></a>

### EN_PH `constants`

##### Summary

English - Philippines

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_TT'></a>

### EN_TT `constants`

##### Summary

English - Trinidad and Tobago

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_US'></a>

### EN_US `constants`

##### Summary

English - United States

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_ZA'></a>

### EN_ZA `constants`

##### Summary

English - South Africa

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EN_ZW'></a>

### EN_ZW `constants`

##### Summary

English - Zimbabwe

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_AR'></a>

### ES_AR `constants`

##### Summary

Spanish - Argentina

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_BO'></a>

### ES_BO `constants`

##### Summary

Spanish - Bolivia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_CL'></a>

### ES_CL `constants`

##### Summary

Spanish - Chile

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_CO'></a>

### ES_CO `constants`

##### Summary

Spanish - Colombia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_CR'></a>

### ES_CR `constants`

##### Summary

Spanish - Costa Rica

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_DO'></a>

### ES_DO `constants`

##### Summary

Spanish - Dominican Republic

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_EC'></a>

### ES_EC `constants`

##### Summary

Spanish - Ecuador

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_ES'></a>

### ES_ES `constants`

##### Summary

Spanish - Spain

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_GT'></a>

### ES_GT `constants`

##### Summary

Spanish - Guatemala

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_HN'></a>

### ES_HN `constants`

##### Summary

Spanish - Honduras

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_MX'></a>

### ES_MX `constants`

##### Summary

Spanish - Mexico

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_NI'></a>

### ES_NI `constants`

##### Summary

Spanish - Nicaragua

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_PA'></a>

### ES_PA `constants`

##### Summary

Spanish - Panama

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_PE'></a>

### ES_PE `constants`

##### Summary

Spanish - Peru

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_PR'></a>

### ES_PR `constants`

##### Summary

Spanish - Puerto Rico

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_PY'></a>

### ES_PY `constants`

##### Summary

Spanish - Paraguay

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_SV'></a>

### ES_SV `constants`

##### Summary

Spanish - El Salvador

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_UY'></a>

### ES_UY `constants`

##### Summary

Spanish - Uruguay

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ES_VE'></a>

### ES_VE `constants`

##### Summary

Spanish - Venezuela

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ET_EE'></a>

### ET_EE `constants`

##### Summary

Estonian - Estonia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-EU_ES'></a>

### EU_ES `constants`

##### Summary

Basque - Basque

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FA_IR'></a>

### FA_IR `constants`

##### Summary

Farsi - Iran

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FI_FI'></a>

### FI_FI `constants`

##### Summary

Finnish - Finland

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FO_FO'></a>

### FO_FO `constants`

##### Summary

Faroese - Faroe Islands

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_BE'></a>

### FR_BE `constants`

##### Summary

French - Belgium

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_CA'></a>

### FR_CA `constants`

##### Summary

French - Canada

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_CH'></a>

### FR_CH `constants`

##### Summary

French - Switzerland

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_FR'></a>

### FR_FR `constants`

##### Summary

French - France

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_LU'></a>

### FR_LU `constants`

##### Summary

French - Luxembourg

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-FR_MC'></a>

### FR_MC `constants`

##### Summary

French - Monaco

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-GL_ES'></a>

### GL_ES `constants`

##### Summary

Galician - Galician

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-GU_IN'></a>

### GU_IN `constants`

##### Summary

Gujarati - India

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HE_IL'></a>

### HE_IL `constants`

##### Summary

Hebrew - Israel

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HI_IN'></a>

### HI_IN `constants`

##### Summary

Hindi - India

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HR_HR'></a>

### HR_HR `constants`

##### Summary

Croatian - Croatia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HU_HU'></a>

### HU_HU `constants`

##### Summary

Hungarian - Hungary

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-HY_AM'></a>

### HY_AM `constants`

##### Summary

Armenian - Armenia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ID_ID'></a>

### ID_ID `constants`

##### Summary

Indonesian - Indonesia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-IS_IS'></a>

### IS_IS `constants`

##### Summary

Icelandic - Iceland

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-IT_CH'></a>

### IT_CH `constants`

##### Summary

Italian - Switzerland

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-IT_IT'></a>

### IT_IT `constants`

##### Summary

Italian - Italy

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-JA_JP'></a>

### JA_JP `constants`

##### Summary

Japanese - Japan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KA_GE'></a>

### KA_GE `constants`

##### Summary

Georgian - Georgia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KK_KZ'></a>

### KK_KZ `constants`

##### Summary

Kazakh - Kazakhstan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KN_IN'></a>

### KN_IN `constants`

##### Summary

Kannada - India

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KOK_IN'></a>

### KOK_IN `constants`

##### Summary

Konkani - India

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KO_KR'></a>

### KO_KR `constants`

##### Summary

Korean - Korea

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-KY_KZ'></a>

### KY_KZ `constants`

##### Summary

Kyrgyz - Kazakhstan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LT_AZ_AZ'></a>

### LT_AZ_AZ `constants`

##### Summary

Azeri (Latin) - Azerbaijan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LT_LT'></a>

### LT_LT `constants`

##### Summary

Lithuanian - Lithuania

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LT_SR_SP'></a>

### LT_SR_SP `constants`

##### Summary

Serbian (Latin) - Serbia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LT_UZ_UZ'></a>

### LT_UZ_UZ `constants`

##### Summary

Uzbek (Latin) - Uzbekistan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-LV_LV'></a>

### LV_LV `constants`

##### Summary

Latvian - Latvia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MK_MK'></a>

### MK_MK `constants`

##### Summary

Macedonian (FYROM)

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MN_MN'></a>

### MN_MN `constants`

##### Summary

Mongolian - Mongolia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MR_IN'></a>

### MR_IN `constants`

##### Summary

Marathi - India

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MS_BN'></a>

### MS_BN `constants`

##### Summary

Malay - Brunei

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-MS_MY'></a>

### MS_MY `constants`

##### Summary

Malay - Malaysia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-NB_NO'></a>

### NB_NO `constants`

##### Summary

Norwegian (Bokmål) - Norway

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-NL_BE'></a>

### NL_BE `constants`

##### Summary

Dutch - Belgium

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-NL_NL'></a>

### NL_NL `constants`

##### Summary

Dutch - The Netherlands

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-NN_NO'></a>

### NN_NO `constants`

##### Summary

Norwegian (Nynorsk) - Norway

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-PA_IN'></a>

### PA_IN `constants`

##### Summary

Punjabi - India

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-PL_PL'></a>

### PL_PL `constants`

##### Summary

Polish - Poland

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-PT_BR'></a>

### PT_BR `constants`

##### Summary

Portuguese - Brazil

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-PT_PT'></a>

### PT_PT `constants`

##### Summary

Portuguese - Portugal

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-RO_RO'></a>

### RO_RO `constants`

##### Summary

Romanian - Romania

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-RU_RU'></a>

### RU_RU `constants`

##### Summary

Russian - Russia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SA_IN'></a>

### SA_IN `constants`

##### Summary

Sanskrit - India

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SK_SK'></a>

### SK_SK `constants`

##### Summary

Slovak - Slovakia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SL_SI'></a>

### SL_SI `constants`

##### Summary

Slovenian - Slovenia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SQ_AL'></a>

### SQ_AL `constants`

##### Summary

Albanian - Albania

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SV_FI'></a>

### SV_FI `constants`

##### Summary

Swedish - Finland

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SV_SE'></a>

### SV_SE `constants`

##### Summary

Swedish - Sweden

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SW_KE'></a>

### SW_KE `constants`

##### Summary

Swahili - Kenya

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-SYR_SY'></a>

### SYR_SY `constants`

##### Summary

Syriac - Syria

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TA_IN'></a>

### TA_IN `constants`

##### Summary

Tamil - India

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TE_IN'></a>

### TE_IN `constants`

##### Summary

Telugu - India

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TH_TH'></a>

### TH_TH `constants`

##### Summary

Thai - Thailand

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TR_TR'></a>

### TR_TR `constants`

##### Summary

Turkish - Turkey

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-TT_RU'></a>

### TT_RU `constants`

##### Summary

Tatar - Russia

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-UK_UA'></a>

### UK_UA `constants`

##### Summary

Ukrainian - Ukraine

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-UR_PK'></a>

### UR_PK `constants`

##### Summary

Urdu - Pakistan

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-VI_VN'></a>

### VI_VN `constants`

##### Summary

Vietnamese - Vietnam

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_CHS'></a>

### ZH_CHS `constants`

##### Summary

Chinese (Simplified)

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_CHT'></a>

### ZH_CHT `constants`

##### Summary

Chinese (Traditional)

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_CN'></a>

### ZH_CN `constants`

##### Summary

Chinese - China

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_HK'></a>

### ZH_HK `constants`

##### Summary

Chinese - Hong Kong SAR

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_MO'></a>

### ZH_MO `constants`

##### Summary

Chinese - Macau SAR

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_SG'></a>

### ZH_SG `constants`

##### Summary

Chinese - Singapore

<a name='F-AndcultureCode-CSharp-Core-Constants-Rfc4646LanguageCodes-ZH_TW'></a>

### ZH_TW `constants`

##### Summary

Chinese - Taiwan

<a name='T-AndcultureCode-CSharp-Core-SeedsBase`1'></a>

## SeedsBase\`1 `type`

##### Namespace

RSM.HCD.CSharp.Core

##### Summary

Shared functionality for configuring application data seeding

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-#ctor-System-IServiceProvider,System-Boolean-'></a>

### #ctor(serviceProvider,isDevelopment) `constructor`

##### Summary

Shared functionality for configuring application data seeding

##### Parameters

| Name            | Type                                                                                                                                                  | Description                       |
| --------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider "System.IServiceProvider") | Application's dependency registry |
| isDevelopment   | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                            | Should development seeds be run?  |

<a name='P-AndcultureCode-CSharp-Core-SeedsBase`1-Context'></a>

### Context `property`

##### Summary

Application's data context

<a name='P-AndcultureCode-CSharp-Core-SeedsBase`1-IsDevelopment'></a>

### IsDevelopment `property`

##### Summary

Should development seeds be run?

<a name='P-AndcultureCode-CSharp-Core-SeedsBase`1-Logger'></a>

### Logger `property`

##### Summary

Logger instance

<a name='P-AndcultureCode-CSharp-Core-SeedsBase`1-ServiceProvider'></a>

### ServiceProvider `property`

##### Summary

Application's dependency registry

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-Create'></a>

### Create() `method`

##### Summary

Primary entry point to initialize seed data

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-CreateBase'></a>

### CreateBase() `method`

##### Summary

Seed data that is required for the application to run, regardless of the environment

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-CreateDevelopment'></a>

### CreateDevelopment() `method`

##### Summary

Seed data that is only for development environments (ie. test accounts, use cases)

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-GetDep``1'></a>

### GetDep\`\`1() `method`

##### Summary

Retrieve dependency from registry

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-Log-System-String,System-String-'></a>

### Log(seedName,message) `method`

##### Summary

Log message for seed name

##### Parameters

| Name     | Type                                                                                                                    | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| seedName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| message  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-LogEnd-System-String-'></a>

### LogEnd(seedName) `method`

##### Summary

Signify completion of seeding a particular seed name

##### Parameters

| Name     | Type                                                                                                                    | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| seedName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-LogEnd``1'></a>

### LogEnd\`\`1() `method`

##### Summary

Signify completion of seeding a particular type

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-LogStart-System-String-'></a>

### LogStart(seedName) `method`

##### Summary

Signify start to seeding a particular seed name

##### Parameters

| Name     | Type                                                                                                                    | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| seedName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-LogStart``1'></a>

### LogStart\`\`1() `method`

##### Summary

Signify start to seeding a particular type

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-SeedsBase`1-Log``1-System-String-'></a>

### Log\`\`1(message) `method`

##### Summary

Log message for seed type

##### Parameters

| Name    | Type                                                                                                                    | Description |
| ------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='T-AndcultureCode-CSharp-Business-Core-Models-Configuration-SeedsConfiguration'></a>

## SeedsConfiguration `type`

##### Namespace

RSM.HCD.CSharp.Business.Core.Models.Configuration

##### Summary

Configuration values around data seeding

<a name='P-AndcultureCode-CSharp-Business-Core-Models-Configuration-SeedsConfiguration-DefaultUserPassword'></a>

### DefaultUserPassword `property`

##### Summary

Password to use when new development/test users are seeded

<a name='T-AndcultureCode-CSharp-Core-Cultures-SpanishSpain'></a>

## SpanishSpain `type`

##### Namespace

RSM.HCD.CSharp.Core.Cultures

##### Summary

Localization Culture for Spanish - Spain (es-US)

<a name='P-AndcultureCode-CSharp-Core-Cultures-SpanishSpain-Code'></a>

### Code `property`

##### Summary

_Inherit from parent._

<a name='T-AndcultureCode-CSharp-Core-Extensions-StringExtensions'></a>

## StringExtensions `type`

##### Namespace

RSM.HCD.CSharp.Core.Extensions

##### Summary

String extension methods

<a name='M-AndcultureCode-CSharp-Core-Extensions-StringExtensions-LoadTranslations-System-String,System-String,Newtonsoft-Json-JsonSerializerSettings-'></a>

### LoadTranslations() `method`

##### Summary

Loads a given translation .json file and maps contents to CultureTranslation objects

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Utilities-Network-UriUtils'></a>

## UriUtils `type`

##### Namespace

RSM.HCD.CSharp.Core.Utilities.Network

##### Summary

URI related helper functions

<a name='M-AndcultureCode-CSharp-Core-Utilities-Network-UriUtils-IsInvalidHttpUrl-System-String-'></a>

### IsInvalidHttpUrl() `method`

##### Summary

Is the supplied source url an invalid HTTP URL?

##### Returns

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Utilities-Network-UriUtils-IsValidHttpUrl-System-String-'></a>

### IsValidHttpUrl() `method`

##### Summary

Is the supplied source url a valid HTTP URL?

##### Returns

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Core-Constants-UserMetadataNames'></a>

## UserMetadataNames `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

UserMetadata name values used by Core actors

<a name='F-AndcultureCode-CSharp-Core-Constants-UserMetadataNames-FACEBOOK'></a>

### FACEBOOK `constants`

##### Summary

Used to identify a facebook related value item (ie. OAuth type)

<a name='F-AndcultureCode-CSharp-Core-Constants-UserMetadataNames-GOOGLE'></a>

### GOOGLE `constants`

##### Summary

Used to identify a google related value item (ie. OAuth type)

<a name='F-AndcultureCode-CSharp-Core-Constants-UserMetadataNames-MICROSOFT'></a>

### MICROSOFT `constants`

##### Summary

Used to identify a microsoft related value item (ie. OAuth type)

<a name='F-AndcultureCode-CSharp-Core-Constants-UserMetadataNames-TWITTER'></a>

### TWITTER `constants`

##### Summary

Used to identify a twitter related value item (ie. OAuth type)

<a name='T-AndcultureCode-CSharp-Core-Constants-UserMetadataTypes'></a>

## UserMetadataTypes `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Commonly used UserMetadata types

<a name='F-AndcultureCode-CSharp-Core-Constants-UserMetadataTypes-ExternalUserId'></a>

### ExternalUserId `constants`

##### Summary

Unique external authentication identifier (ie. oauth, client specific auth)

<a name='T-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider'></a>

## WorkerProvider `type`

##### Namespace

RSM.HCD.CSharp.Core.Providers.Worker

##### Summary

Base class for implementing common worker functionality

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Delete-System-String-'></a>

### Delete(id) `method`

##### Summary

Deletes a job by its identifier

##### Returns

success status

##### Parameters

| Name | Type                                                                                                                    | Description    |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | -------------- |
| id   | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | job identifier |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-DeletedCount'></a>

### DeletedCount() `method`

##### Summary

Count of deleted jobs

##### Returns

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Enqueue-System-Linq-Expressions-Expression{System-Action}-'></a>

### Enqueue(methodCall) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                 | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action}") |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Enqueue``1-System-Linq-Expressions-Expression{System-Action{``0}}-'></a>

### Enqueue\`\`1(methodCall) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                             | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-EnqueuedCount-System-String-'></a>

### EnqueuedCount(queue) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Returns

##### Parameters

| Name  | Type                                                                                                                    | Description |
| ----- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| queue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Recur-System-String,System-Linq-Expressions-Expression{System-Action},AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-'></a>

### Recur(id,methodCall,recurringOptions) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Parameters

| Name             | Type                                                                                                                                                                                                                 | Description |
| ---------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| id               | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                              |             |
| methodCall       | [System.Linq.Expressions.Expression{System.Action}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action}") |             |
| recurringOptions | [RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption](#T-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption")                      |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Recur``1-System-String,System-Linq-Expressions-Expression{System-Action{``0}},System-String-'></a>

### Recur\`\`1(id,methodCall,chronExpression) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Parameters

| Name            | Type                                                                                                                                                                                                                             | Description |
| --------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| id              | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                          |             |
| methodCall      | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |
| chronExpression | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                          |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Recur``1-System-String,System-Linq-Expressions-Expression{System-Action{``0}},AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption-'></a>

### Recur\`\`1(id,methodCall,recurringOptions) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Parameters

| Name             | Type                                                                                                                                                                                                                             | Description |
| ---------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| id               | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                          |             |
| methodCall       | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |
| recurringOptions | [RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption](#T-AndcultureCode-CSharp-Core-Models-Entities-Worker-RecurringOption "RSM.HCD.CSharp.Core.Models.Entities.Worker.RecurringOption")                                  |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-RecurringCount'></a>

### RecurringCount() `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Returns

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-RemoveRecurrence-System-String-'></a>

### RemoveRecurrence(id) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Parameters

| Name | Type                                                                                                                    | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| id   | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Schedule-System-Linq-Expressions-Expression{System-Action},System-DateTimeOffset-'></a>

### Schedule(methodCall,enqueueOn) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                 | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action}") |             |
| enqueueOn  | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset "System.DateTimeOffset")                                                                      |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Schedule-System-Linq-Expressions-Expression{System-Action},System-TimeSpan-'></a>

### Schedule(methodCall,delay) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                 | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action}") |             |
| delay      | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan "System.TimeSpan")                                                                                        |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Schedule``1-System-Linq-Expressions-Expression{System-Action{``0}},System-DateTimeOffset-'></a>

### Schedule\`\`1(methodCall,enqueueOn) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                             | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |
| enqueueOn  | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset "System.DateTimeOffset")                                                                                  |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Core-Providers-Worker-WorkerProvider-Schedule``1-System-Linq-Expressions-Expression{System-Action{``0}},System-TimeSpan-'></a>

### Schedule\`\`1(methodCall,delay) `method`

##### Summary

TODO https://github.com/rsm-hcd/RSM.HCD.CSharp.Core/issues/39

##### Returns

##### Parameters

| Name       | Type                                                                                                                                                                                                                             | Description |
| ---------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| methodCall | [System.Linq.Expressions.Expression{System.Action{\`\`0}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Action{``0}}") |
| delay      | [System.TimeSpan](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.TimeSpan "System.TimeSpan")                                                                                                    |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |
