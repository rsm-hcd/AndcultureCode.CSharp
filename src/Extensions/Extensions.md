<a name='assembly'></a>

# RSM.HCD.CSharp.Extensions

## Contents

-   [ApiClaimTypes](#T-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes")
    -   [IS_SUPER_ADMIN](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-IS_SUPER_ADMIN "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.IS_SUPER_ADMIN")
    -   [ROLE_ID](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-ROLE_ID "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.ROLE_ID")
    -   [ROLE_IDS](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-ROLE_IDS "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.ROLE_IDS")
    -   [ROLE_TYPE](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-ROLE_TYPE "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.ROLE_TYPE")
    -   [USER_ID](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-USER_ID "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.USER_ID")
    -   [USER_LOGIN_ID](#F-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes-USER_LOGIN_ID "RSM.HCD.CSharp.Core.Constants.ApiClaimTypes.USER_LOGIN_ID")
-   [AssemblyExtensions](#T-AndcultureCode-CSharp-Extensions-AssemblyExtensions "RSM.HCD.CSharp.Extensions.AssemblyExtensions")
    -   [GetLoadableTypes(assembly)](#M-AndcultureCode-CSharp-Extensions-AssemblyExtensions-GetLoadableTypes-System-Reflection-Assembly- "RSM.HCD.CSharp.Extensions.AssemblyExtensions.GetLoadableTypes(System.Reflection.Assembly)")
-   [ClaimsPrincipalExtensions](#T-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions "RSM.HCD.CSharp.Extensions.ClaimsPrincipalExtensions")
    -   [IsAuthenticated(principal)](#M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-IsAuthenticated-System-Security-Claims-ClaimsPrincipal- "RSM.HCD.CSharp.Extensions.ClaimsPrincipalExtensions.IsAuthenticated(System.Security.Claims.ClaimsPrincipal)")
    -   [IsSuperAdmin(principal)](#M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-IsSuperAdmin-System-Security-Claims-ClaimsPrincipal- "RSM.HCD.CSharp.Extensions.ClaimsPrincipalExtensions.IsSuperAdmin(System.Security.Claims.ClaimsPrincipal)")
    -   [IsUnauthenticated(principal)](#M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-IsUnauthenticated-System-Security-Claims-ClaimsPrincipal- "RSM.HCD.CSharp.Extensions.ClaimsPrincipalExtensions.IsUnauthenticated(System.Security.Claims.ClaimsPrincipal)")
    -   [RoleId(principal)](#M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-RoleId-System-Security-Claims-ClaimsPrincipal- "RSM.HCD.CSharp.Extensions.ClaimsPrincipalExtensions.RoleId(System.Security.Claims.ClaimsPrincipal)")
    -   [RoleIds(principal)](#M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-RoleIds-System-Security-Claims-ClaimsPrincipal- "RSM.HCD.CSharp.Extensions.ClaimsPrincipalExtensions.RoleIds(System.Security.Claims.ClaimsPrincipal)")
    -   [UserId(principal)](#M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-UserId-System-Security-Claims-ClaimsPrincipal- "RSM.HCD.CSharp.Extensions.ClaimsPrincipalExtensions.UserId(System.Security.Claims.ClaimsPrincipal)")
    -   [UserLoginId(principal)](#M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-UserLoginId-System-Security-Claims-ClaimsPrincipal- "RSM.HCD.CSharp.Extensions.ClaimsPrincipalExtensions.UserLoginId(System.Security.Claims.ClaimsPrincipal)")
-   [DateExtensions](#T-AndcultureCode-CSharp-Extensions-DateExtensions "RSM.HCD.CSharp.Extensions.DateExtensions")
    -   [AtEndOfDay(date)](#M-AndcultureCode-CSharp-Extensions-DateExtensions-AtEndOfDay-System-DateTimeOffset- "RSM.HCD.CSharp.Extensions.DateExtensions.AtEndOfDay(System.DateTimeOffset)")
    -   [AtMidnight(date)](#M-AndcultureCode-CSharp-Extensions-DateExtensions-AtMidnight-System-DateTimeOffset- "RSM.HCD.CSharp.Extensions.DateExtensions.AtMidnight(System.DateTimeOffset)")
    -   [CalculateAge()](#M-AndcultureCode-CSharp-Extensions-DateExtensions-CalculateAge-System-DateTime- "RSM.HCD.CSharp.Extensions.DateExtensions.CalculateAge(System.DateTime)")
    -   [IsBetweenDates()](#M-AndcultureCode-CSharp-Extensions-DateExtensions-IsBetweenDates-System-DateTimeOffset,System-DateTimeOffset,System-DateTimeOffset- "RSM.HCD.CSharp.Extensions.DateExtensions.IsBetweenDates(System.DateTimeOffset,System.DateTimeOffset,System.DateTimeOffset)")
    -   [IsBetweenDates()](#M-AndcultureCode-CSharp-Extensions-DateExtensions-IsBetweenDates-System-DateTimeOffset,System-DateTimeOffset,System-DateTimeOffset,System-Boolean- "RSM.HCD.CSharp.Extensions.DateExtensions.IsBetweenDates(System.DateTimeOffset,System.DateTimeOffset,System.DateTimeOffset,System.Boolean)")
    -   [SetTime(date,hour,minute,second)](#M-AndcultureCode-CSharp-Extensions-DateExtensions-SetTime-System-DateTimeOffset,System-Int32,System-Int32,System-Int32- "RSM.HCD.CSharp.Extensions.DateExtensions.SetTime(System.DateTimeOffset,System.Int32,System.Int32,System.Int32)")
    -   [SubtractWeekdays()](#M-AndcultureCode-CSharp-Extensions-DateExtensions-SubtractWeekdays-System-DateTime,System-Int32- "RSM.HCD.CSharp.Extensions.DateExtensions.SubtractWeekdays(System.DateTime,System.Int32)")
    -   [SubtractWeekdays()](#M-AndcultureCode-CSharp-Extensions-DateExtensions-SubtractWeekdays-System-DateTimeOffset,System-Int32- "RSM.HCD.CSharp.Extensions.DateExtensions.SubtractWeekdays(System.DateTimeOffset,System.Int32)")
-   [DictionaryExtensions](#T-AndcultureCode-CSharp-Extensions-DictionaryExtensions "RSM.HCD.CSharp.Extensions.DictionaryExtensions")
    -   [Merge\`\`2(left,right,takeLastKey)](#M-AndcultureCode-CSharp-Extensions-DictionaryExtensions-Merge``2-System-Collections-Generic-Dictionary{``0,``1},System-Collections-Generic-Dictionary{``0,``1},System-Boolean- "RSM.HCD.CSharp.Extensions.DictionaryExtensions.Merge``2(System.Collections.Generic.Dictionary{``0,``1},System.Collections.Generic.Dictionary{``0,``1},System.Boolean)")
-   [ExpressionExtensions](#T-AndcultureCode-CSharp-Extensions-ExpressionExtensions "RSM.HCD.CSharp.Extensions.ExpressionExtensions")
    -   [AndAlso\`\`1(expr1,expr2)](#M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-AndAlso``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- "RSM.HCD.CSharp.Extensions.ExpressionExtensions.AndAlso``1(System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})")
    -   [AndAlso\`\`2(expr1,expr2,navigationProperty)](#M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-AndAlso``2-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``1,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,``1}}- "RSM.HCD.CSharp.Extensions.ExpressionExtensions.AndAlso``2(System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``1,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``0,``1}})")
    -   [OrElse\`\`1(expr1,expr2)](#M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-OrElse``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- "RSM.HCD.CSharp.Extensions.ExpressionExtensions.OrElse``1(System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})")
    -   [OrElse\`\`2(expr1,expr2,navigationProperty)](#M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-OrElse``2-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``1,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,``1}}- "RSM.HCD.CSharp.Extensions.ExpressionExtensions.OrElse``2(System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``1,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``0,``1}})")
    -   [Or\`\`1(expr1,expr2)](#M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-Or``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- "RSM.HCD.CSharp.Extensions.ExpressionExtensions.Or``1(System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})")
    -   [Or\`\`2(expr1,expr2,navigationProperty)](#M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-Or``2-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``1,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,``1}}- "RSM.HCD.CSharp.Extensions.ExpressionExtensions.Or``2(System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``1,System.Boolean}},System.Linq.Expressions.Expression{System.Func{``0,``1}})")
-   [HttpRequestExtensions](#T-AndcultureCode-CSharp-Extensions-HttpRequestExtensions "RSM.HCD.CSharp.Extensions.HttpRequestExtensions")
    -   [X_FORWARDED_FOR](#F-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-X_FORWARDED_FOR "RSM.HCD.CSharp.Extensions.HttpRequestExtensions.X_FORWARDED_FOR")
    -   [GetCookie(request,name)](#M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-GetCookie-Microsoft-AspNetCore-Http-HttpRequest,System-String- "RSM.HCD.CSharp.Extensions.HttpRequestExtensions.GetCookie(Microsoft.AspNetCore.Http.HttpRequest,System.String)")
    -   [GetHeader(request,name)](#M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-GetHeader-Microsoft-AspNetCore-Http-HttpRequest,System-String- "RSM.HCD.CSharp.Extensions.HttpRequestExtensions.GetHeader(Microsoft.AspNetCore.Http.HttpRequest,System.String)")
    -   [GetIpAddress(request)](#M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-GetIpAddress-Microsoft-AspNetCore-Http-HttpRequest- "RSM.HCD.CSharp.Extensions.HttpRequestExtensions.GetIpAddress(Microsoft.AspNetCore.Http.HttpRequest)")
    -   [GetUserAgent()](#M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-GetUserAgent-Microsoft-AspNetCore-Http-HttpRequest- "RSM.HCD.CSharp.Extensions.HttpRequestExtensions.GetUserAgent(Microsoft.AspNetCore.Http.HttpRequest)")
    -   [HasCookie(request,name)](#M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-HasCookie-Microsoft-AspNetCore-Http-HttpRequest,System-String- "RSM.HCD.CSharp.Extensions.HttpRequestExtensions.HasCookie(Microsoft.AspNetCore.Http.HttpRequest,System.String)")
-   [HttpResponseMessageExtensions](#T-AndcultureCode-CSharp-Extensions-HttpResponseMessageExtensions "RSM.HCD.CSharp.Extensions.HttpResponseMessageExtensions")
    -   [FromJson\`\`1(response)](#M-AndcultureCode-CSharp-Extensions-HttpResponseMessageExtensions-FromJson``1-System-Net-Http-HttpResponseMessage- "RSM.HCD.CSharp.Extensions.HttpResponseMessageExtensions.FromJson``1(System.Net.Http.HttpResponseMessage)")
-   [IConfigurationRootExtensions](#T-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions "RSM.HCD.CSharp.Extensions.IConfigurationRootExtensions")
    -   [CONFIGURATION_VERSION_DEVELOPMENT_VALUE](#F-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-CONFIGURATION_VERSION_DEVELOPMENT_VALUE "RSM.HCD.CSharp.Extensions.IConfigurationRootExtensions.CONFIGURATION_VERSION_DEVELOPMENT_VALUE")
    -   [CONFIGURATION_VERSION_KEY](#F-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-CONFIGURATION_VERSION_KEY "RSM.HCD.CSharp.Extensions.IConfigurationRootExtensions.CONFIGURATION_VERSION_KEY")
    -   [CONFIGURATION_VERSION_TEMPLATE](#F-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-CONFIGURATION_VERSION_TEMPLATE "RSM.HCD.CSharp.Extensions.IConfigurationRootExtensions.CONFIGURATION_VERSION_TEMPLATE")
    -   [DEFAULT_DATABASE_KEY](#F-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-DEFAULT_DATABASE_KEY "RSM.HCD.CSharp.Extensions.IConfigurationRootExtensions.DEFAULT_DATABASE_KEY")
    -   [GetDatabaseConnectionString(configuration,databaseKey)](#M-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-GetDatabaseConnectionString-Microsoft-Extensions-Configuration-IConfigurationRoot,System-String- "RSM.HCD.CSharp.Extensions.IConfigurationRootExtensions.GetDatabaseConnectionString(Microsoft.Extensions.Configuration.IConfigurationRoot,System.String)")
    -   [GetDatabaseName(configuration)](#M-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-GetDatabaseName-Microsoft-Extensions-Configuration-IConfigurationRoot- "RSM.HCD.CSharp.Extensions.IConfigurationRootExtensions.GetDatabaseName(Microsoft.Extensions.Configuration.IConfigurationRoot)")
    -   [GetVersion(configuration,isDevelopment)](#M-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-GetVersion-Microsoft-Extensions-Configuration-IConfigurationRoot,System-Boolean- "RSM.HCD.CSharp.Extensions.IConfigurationRootExtensions.GetVersion(Microsoft.Extensions.Configuration.IConfigurationRoot,System.Boolean)")
-   [IEnumerableExtensions](#T-AndcultureCode-CSharp-Extensions-IEnumerableExtensions "RSM.HCD.CSharp.Extensions.IEnumerableExtensions")
    -   [Except\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Except``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,System-Boolean}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.Except``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,System.Boolean})")
    -   [HasValues\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-HasValues``1-System-Collections-Generic-IEnumerable{``0}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.HasValues``1(System.Collections.Generic.IEnumerable{``0})")
    -   [HasValues\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-HasValues``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.HasValues``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})")
    -   [Intersect\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Intersect``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,System-Boolean}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.Intersect``1(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``0},System.Func{``0,``0,System.Boolean})")
    -   [IsEmpty\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-IsEmpty``1-System-Collections-Generic-IEnumerable{``0}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.IsEmpty``1(System.Collections.Generic.IEnumerable{``0})")
    -   [IsEmpty\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-IsEmpty``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.IsEmpty``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})")
    -   [IsNullOrEmpty\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.IsNullOrEmpty``1(System.Collections.Generic.IEnumerable{``0})")
    -   [IsNullOrEmpty\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.IsNullOrEmpty``1(System.Collections.Generic.IEnumerable{``0},System.Func{``0,System.Boolean})")
    -   [Join()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Join-System-Collections-Generic-IEnumerable{System-String},System-String- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.Join(System.Collections.Generic.IEnumerable{System.String},System.String)")
    -   [Join()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Join-System-Collections-Generic-IEnumerable{System-Collections-Generic-KeyValuePair{System-String,System-String}},System-String,System-String- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.Join(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{System.String,System.String}},System.String,System.String)")
    -   [Join()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Join-System-Collections-Generic-List{System-String},System-String- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.Join(System.Collections.Generic.List{System.String},System.String)")
    -   [Join()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Join-System-Collections-Generic-KeyValuePair{System-String,System-String},System-String- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.Join(System.Collections.Generic.KeyValuePair{System.String,System.String},System.String)")
    -   [PickRandom\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-PickRandom``1-System-Collections-Generic-IEnumerable{``0}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.PickRandom``1(System.Collections.Generic.IEnumerable{``0})")
    -   [PickRandom\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-PickRandom``1-System-Collections-Generic-IEnumerable{``0},System-Int32- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.PickRandom``1(System.Collections.Generic.IEnumerable{``0},System.Int32)")
    -   [Shuffle\`\`1()](#M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0}- "RSM.HCD.CSharp.Extensions.IEnumerableExtensions.Shuffle``1(System.Collections.Generic.IEnumerable{``0})")
-   [IQueryableExtensions](#T-AndcultureCode-CSharp-Extensions-IQueryableExtensions "RSM.HCD.CSharp.Extensions.IQueryableExtensions")
    -   [AppendOrderByExpression\`\`1(query,propertyName,direction,isAdditionalOrderBy)](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-AppendOrderByExpression``1-System-Linq-IQueryable{``0},System-String,AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection,System-Boolean- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.AppendOrderByExpression``1(System.Linq.IQueryable{``0},System.String,RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection,System.Boolean)")
    -   [HasValues\`\`1()](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-HasValues``1-System-Linq-IQueryable{``0}- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.HasValues``1(System.Linq.IQueryable{``0})")
    -   [HasValues\`\`1()](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-HasValues``1-System-Linq-IQueryable{``0},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.HasValues``1(System.Linq.IQueryable{``0},System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})")
    -   [IsEmpty\`\`1()](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-IsEmpty``1-System-Linq-IQueryable{``0}- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.IsEmpty``1(System.Linq.IQueryable{``0})")
    -   [IsEmpty\`\`1()](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-IsEmpty``1-System-Linq-IQueryable{``0},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.IsEmpty``1(System.Linq.IQueryable{``0},System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})")
    -   [IsNullOrEmpty\`\`1()](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-IsNullOrEmpty``1-System-Linq-IQueryable{``0}- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.IsNullOrEmpty``1(System.Linq.IQueryable{``0})")
    -   [IsNullOrEmpty\`\`1()](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-IsNullOrEmpty``1-System-Linq-IQueryable{``0},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.IsNullOrEmpty``1(System.Linq.IQueryable{``0},System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}})")
    -   [OrderBy\`\`1(query,propertyName,direction)](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-OrderBy``1-System-Linq-IQueryable{``0},System-String,AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.OrderBy``1(System.Linq.IQueryable{``0},System.String,RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection)")
    -   [PickRandom\`\`1(source)](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-PickRandom``1-System-Linq-IQueryable{``0}- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.PickRandom``1(System.Linq.IQueryable{``0})")
    -   [PickRandom\`\`1()](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-PickRandom``1-System-Linq-IQueryable{``0},System-Int32- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.PickRandom``1(System.Linq.IQueryable{``0},System.Int32)")
    -   [Shuffle\`\`1()](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-Shuffle``1-System-Linq-IQueryable{``0}- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.Shuffle``1(System.Linq.IQueryable{``0})")
    -   [ThenBy\`\`1(query,propertyName,direction)](#M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-ThenBy``1-System-Linq-IOrderedQueryable{``0},System-String,AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection- "RSM.HCD.CSharp.Extensions.IQueryableExtensions.ThenBy``1(System.Linq.IOrderedQueryable{``0},System.String,RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection)")
-   [LambdaComparer\`1](#T-AndcultureCode-CSharp-Extensions-Models-LambdaComparer`1 "RSM.HCD.CSharp.Extensions.Models.LambdaComparer`1")
    -   [#ctor(predicate)](#M-AndcultureCode-CSharp-Extensions-Models-LambdaComparer`1-#ctor-System-Func{`0,`0,System-Boolean}- "RSM.HCD.CSharp.Extensions.Models.LambdaComparer`1.#ctor(System.Func{`0,`0,System.Boolean})")
    -   [Equals()](#M-AndcultureCode-CSharp-Extensions-Models-LambdaComparer`1-Equals-`0,`0- "RSM.HCD.CSharp.Extensions.Models.LambdaComparer`1.Equals(`0,`0)")
    -   [GetHashCode()](#M-AndcultureCode-CSharp-Extensions-Models-LambdaComparer`1-GetHashCode-`0- "RSM.HCD.CSharp.Extensions.Models.LambdaComparer`1.GetHashCode(`0)")
-   [OrderByDirection](#T-AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection "RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection")
    -   [Ascending](#F-AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection-Ascending "RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection.Ascending")
    -   [Descending](#F-AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection-Descending "RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection.Descending")
-   [StringExtensions](#T-AndcultureCode-CSharp-Extensions-StringExtensions "RSM.HCD.CSharp.Extensions.StringExtensions")
    -   [AsIndentedJson(str)](#M-AndcultureCode-CSharp-Extensions-StringExtensions-AsIndentedJson-System-String- "RSM.HCD.CSharp.Extensions.StringExtensions.AsIndentedJson(System.String)")
    -   [IsInvalidHttpUrl(source)](#M-AndcultureCode-CSharp-Extensions-StringExtensions-IsInvalidHttpUrl-System-String- "RSM.HCD.CSharp.Extensions.StringExtensions.IsInvalidHttpUrl(System.String)")
    -   [IsNotValidGuid(guidString)](#M-AndcultureCode-CSharp-Extensions-StringExtensions-IsNotValidGuid-System-String- "RSM.HCD.CSharp.Extensions.StringExtensions.IsNotValidGuid(System.String)")
    -   [IsValidEmail(email)](#M-AndcultureCode-CSharp-Extensions-StringExtensions-IsValidEmail-System-String- "RSM.HCD.CSharp.Extensions.StringExtensions.IsValidEmail(System.String)")
    -   [IsValidGuid(guidString)](#M-AndcultureCode-CSharp-Extensions-StringExtensions-IsValidGuid-System-String- "RSM.HCD.CSharp.Extensions.StringExtensions.IsValidGuid(System.String)")
    -   [IsValidHttpUrl(source)](#M-AndcultureCode-CSharp-Extensions-StringExtensions-IsValidHttpUrl-System-String- "RSM.HCD.CSharp.Extensions.StringExtensions.IsValidHttpUrl(System.String)")
    -   [ToBoolean()](#M-AndcultureCode-CSharp-Extensions-StringExtensions-ToBoolean-System-String- "RSM.HCD.CSharp.Extensions.StringExtensions.ToBoolean(System.String)")
    -   [ToEnumerable\`\`1(input,separator)](#M-AndcultureCode-CSharp-Extensions-StringExtensions-ToEnumerable``1-System-String,System-Char- "RSM.HCD.CSharp.Extensions.StringExtensions.ToEnumerable``1(System.String,System.Char)")
    -   [ToInt(number,defaultValue)](#M-AndcultureCode-CSharp-Extensions-StringExtensions-ToInt-System-String,System-Int32- "RSM.HCD.CSharp.Extensions.StringExtensions.ToInt(System.String,System.Int32)")
    -   [TryChangeType(value,conversionType)](#M-AndcultureCode-CSharp-Extensions-StringExtensions-TryChangeType-System-Object,System-Type- "RSM.HCD.CSharp.Extensions.StringExtensions.TryChangeType(System.Object,System.Type)")
-   [TypeExtensions](#T-AndcultureCode-CSharp-Extensions-TypeExtensions "RSM.HCD.CSharp.Extensions.TypeExtensions")
    -   [GetPublicConstantValues\`\`1()](#M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetPublicConstantValues``1-System-Type- "RSM.HCD.CSharp.Extensions.TypeExtensions.GetPublicConstantValues``1(System.Type)")
    -   [GetPublicPropertyInfo(type,propertyName)](#M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetPublicPropertyInfo-System-Type,System-String- "RSM.HCD.CSharp.Extensions.TypeExtensions.GetPublicPropertyInfo(System.Type,System.String)")
    -   [GetPublicPropertyValue(src,propertyName)](#M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetPublicPropertyValue-System-Object,System-String- "RSM.HCD.CSharp.Extensions.TypeExtensions.GetPublicPropertyValue(System.Object,System.String)")
    -   [GetPublicPropertyValue\`\`1(src,propertyName)](#M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetPublicPropertyValue``1-System-Object,System-String- "RSM.HCD.CSharp.Extensions.TypeExtensions.GetPublicPropertyValue``1(System.Object,System.String)")
    -   [GetTypeName(obj)](#M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetTypeName-System-Object- "RSM.HCD.CSharp.Extensions.TypeExtensions.GetTypeName(System.Object)")
    -   [GetTypeName(type)](#M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetTypeName-System-Type- "RSM.HCD.CSharp.Extensions.TypeExtensions.GetTypeName(System.Type)")
    -   [HasPublicProperty(type,propertyName)](#M-AndcultureCode-CSharp-Extensions-TypeExtensions-HasPublicProperty-System-Type,System-String- "RSM.HCD.CSharp.Extensions.TypeExtensions.HasPublicProperty(System.Type,System.String)")
    -   [WhereWithAttribute\`\`1()](#M-AndcultureCode-CSharp-Extensions-TypeExtensions-WhereWithAttribute``1-System-Collections-Generic-IEnumerable{System-Type}- "RSM.HCD.CSharp.Extensions.TypeExtensions.WhereWithAttribute``1(System.Collections.Generic.IEnumerable{System.Type})")
    -   [WhereWithoutAttribute\`\`1()](#M-AndcultureCode-CSharp-Extensions-TypeExtensions-WhereWithoutAttribute``1-System-Collections-Generic-IEnumerable{System-Type}- "RSM.HCD.CSharp.Extensions.TypeExtensions.WhereWithoutAttribute``1(System.Collections.Generic.IEnumerable{System.Type})")

<a name='T-AndcultureCode-CSharp-Core-Constants-ApiClaimTypes'></a>

## ApiClaimTypes `type`

##### Namespace

RSM.HCD.CSharp.Core.Constants

##### Summary

Commonly used Claim types for APIs

TODO: Migrate to RSM.HCD.CSharp.Core

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

<a name='T-AndcultureCode-CSharp-Extensions-AssemblyExtensions'></a>

## AssemblyExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

Extensions for Assembly

<a name='M-AndcultureCode-CSharp-Extensions-AssemblyExtensions-GetLoadableTypes-System-Reflection-Assembly-'></a>

### GetLoadableTypes(assembly) `method`

##### Summary

Safely returns types that can be loaded from the given assembly

##### Returns

##### Parameters

| Name     | Type                                                                                                                                                           | Description |
| -------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| assembly | [System.Reflection.Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly "System.Reflection.Assembly") |             |

<a name='T-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions'></a>

## ClaimsPrincipalExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

Extension methods for ClaimsPrincipal

<a name='M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-IsAuthenticated-System-Security-Claims-ClaimsPrincipal-'></a>

### IsAuthenticated(principal) `method`

##### Summary

Whether the current user is authenticated

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                               | Description |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| principal | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal "System.Security.Claims.ClaimsPrincipal") |             |

<a name='M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-IsSuperAdmin-System-Security-Claims-ClaimsPrincipal-'></a>

### IsSuperAdmin(principal) `method`

##### Summary

Retrieves whether the user is a super admin by way of their identity claims

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                               | Description |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| principal | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal "System.Security.Claims.ClaimsPrincipal") |             |

<a name='M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-IsUnauthenticated-System-Security-Claims-ClaimsPrincipal-'></a>

### IsUnauthenticated(principal) `method`

##### Summary

Whether the current user is unauthenticated

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                               | Description |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| principal | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal "System.Security.Claims.ClaimsPrincipal") |             |

<a name='M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-RoleId-System-Security-Claims-ClaimsPrincipal-'></a>

### RoleId(principal) `method`

##### Summary

Retrieves user's current role id by way of their identity claims

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                               | Description |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| principal | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal "System.Security.Claims.ClaimsPrincipal") |             |

<a name='M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-RoleIds-System-Security-Claims-ClaimsPrincipal-'></a>

### RoleIds(principal) `method`

##### Summary

Retrieves user's role ids by way of their identity claims

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                               | Description |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| principal | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal "System.Security.Claims.ClaimsPrincipal") |             |

<a name='M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-UserId-System-Security-Claims-ClaimsPrincipal-'></a>

### UserId(principal) `method`

##### Summary

Retrieves user's id by way of identity claims

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                               | Description |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| principal | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal "System.Security.Claims.ClaimsPrincipal") |             |

<a name='M-AndcultureCode-CSharp-Extensions-ClaimsPrincipalExtensions-UserLoginId-System-Security-Claims-ClaimsPrincipal-'></a>

### UserLoginId(principal) `method`

##### Summary

Retrieves user's UserLoginId from identity claims.

##### Returns

##### Parameters

| Name      | Type                                                                                                                                                                                               | Description |
| --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| principal | [System.Security.Claims.ClaimsPrincipal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Claims.ClaimsPrincipal "System.Security.Claims.ClaimsPrincipal") |             |

<a name='T-AndcultureCode-CSharp-Extensions-DateExtensions'></a>

## DateExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

DateTime/Offset Extensions

<a name='M-AndcultureCode-CSharp-Extensions-DateExtensions-AtEndOfDay-System-DateTimeOffset-'></a>

### AtEndOfDay(date) `method`

##### Summary

Sets and returns the time to 11:59:59 on the given DateTimeOffset.

##### Returns

##### Parameters

| Name | Type                                                                                                                                            | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| date | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset "System.DateTimeOffset") |             |

<a name='M-AndcultureCode-CSharp-Extensions-DateExtensions-AtMidnight-System-DateTimeOffset-'></a>

### AtMidnight(date) `method`

##### Summary

Useful when you only care about the date, but do not want to lose the offset.
Returns the midnight representation of the given DateTimeOffset.

##### Returns

##### Parameters

| Name | Type                                                                                                                                            | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| date | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset "System.DateTimeOffset") |             |

<a name='M-AndcultureCode-CSharp-Extensions-DateExtensions-CalculateAge-System-DateTime-'></a>

### CalculateAge() `method`

##### Summary

Convenience method to calculate an age from a birthdate

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-DateExtensions-IsBetweenDates-System-DateTimeOffset,System-DateTimeOffset,System-DateTimeOffset-'></a>

### IsBetweenDates() `method`

##### Summary

Convenience method to default the inclusive parameter
LINQ doesn't like optional parameters on methods used in expressions

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-DateExtensions-IsBetweenDates-System-DateTimeOffset,System-DateTimeOffset,System-DateTimeOffset,System-Boolean-'></a>

### IsBetweenDates() `method`

##### Summary

Provides filtering method for date ranges (excluding time portions)

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-DateExtensions-SetTime-System-DateTimeOffset,System-Int32,System-Int32,System-Int32-'></a>

### SetTime(date,hour,minute,second) `method`

##### Summary

Sets the hour, minute, and second on the given DateTimeOffset with the supplied values.

##### Returns

##### Parameters

| Name   | Type                                                                                                                                            | Description |
| ------ | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| date   | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset "System.DateTimeOffset") |             |
| hour   | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 "System.Int32")                            |             |
| minute | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 "System.Int32")                            |             |
| second | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 "System.Int32")                            |             |

<a name='M-AndcultureCode-CSharp-Extensions-DateExtensions-SubtractWeekdays-System-DateTime,System-Int32-'></a>

### SubtractWeekdays() `method`

##### Summary

Convenience method to subtract weekdays

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-DateExtensions-SubtractWeekdays-System-DateTimeOffset,System-Int32-'></a>

### SubtractWeekdays() `method`

##### Summary

Convenience method to subtract weekdays

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Extensions-DictionaryExtensions'></a>

## DictionaryExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

Extension methods for Dictionary

<a name='M-AndcultureCode-CSharp-Extensions-DictionaryExtensions-Merge``2-System-Collections-Generic-Dictionary{``0,``1},System-Collections-Generic-Dictionary{``0,``1},System-Boolean-'></a>

### Merge\`\`2(left,right,takeLastKey) `method`

##### Summary

'Merges' two dictionaries into one. If duplicate keys are encountered, either the first
or last occurrence will be used. See 'takeLastKey'

##### Returns

##### Parameters

| Name                                                                               | Type                                                                                                                                                                                                                  | Description                                                                             |
| ---------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| left                                                                               | [System.Collections.Generic.Dictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary "System.Collections.Generic.Dictionary{``0,``1}") | Dictionary to be merged into.                                                           |
| right                                                                              | [System.Collections.Generic.Dictionary{\`\`0,\`\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary "System.Collections.Generic.Dictionary{``0,``1}") | Dictionary to be merged into the left dictionary.                                       |
| takeLastKey                                                                        | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                            | Determines whether the value of the last occurrence of a key is used as the final value |
| when duplicates are encountered. If false, uses the value of the first occurrence. |

##### Generic Types

| Name   | Description |
| ------ | ----------- |
| TKey   |             |
| TValue |             |

<a name='T-AndcultureCode-CSharp-Extensions-ExpressionExtensions'></a>

## ExpressionExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

Expression extension methods

<a name='M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-AndAlso``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>

### AndAlso\`\`1(expr1,expr2) `method`

##### Summary

Adds another expression filter to original expression using AndAlso operator

##### Returns

##### Parameters

| Name  | Type                                                                                                                                                                                                                                                                                                                                        | Description |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| expr1 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}") | Main filter expression                                                         |
| expr2 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}") | Additional filter expression on the same type of object as the main expression |

##### Generic Types

| Name | Description                       |
| ---- | --------------------------------- |
| T    | Type of object in the main filter |

<a name='M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-AndAlso``2-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``1,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,``1}}-'></a>

### AndAlso\`\`2(expr1,expr2,navigationProperty) `method`

##### Summary

Adds another expression filter to original expression using AndAlso operator

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                                                  | Description                                                   |
| ------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| expr1              | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}") | Main filter expression                                   |
| expr2              | [System.Linq.Expressions.Expression{System.Func{\`\`1,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``1,System.Boolean}}") | Filter expression that filters on the navigated property |
| navigationProperty | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,``1}}")                                                                                | Expression to the navigation property (eg e => e.PropA.PropB) |

##### Generic Types

| Name | Description                                            |
| ---- | ------------------------------------------------------ |
| T    | Type of object in the main filter                      |
| TNav | Type of the navigation property (can be deeply nested) |

<a name='M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-OrElse``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>

### OrElse\`\`1(expr1,expr2) `method`

##### Summary

Adds another expression filter to original expression using OrElse operator

##### Returns

##### Parameters

| Name  | Type                                                                                                                                                                                                                                                                                                                                        | Description |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| expr1 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}") | Main filter expression                                                         |
| expr2 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}") | Additional filter expression on the same type of object as the main expression |

##### Generic Types

| Name | Description                       |
| ---- | --------------------------------- |
| T    | Type of object in the main filter |

<a name='M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-OrElse``2-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``1,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,``1}}-'></a>

### OrElse\`\`2(expr1,expr2,navigationProperty) `method`

##### Summary

Adds another expression filter to original expression using OrElse operator

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                                                  | Description                                                   |
| ------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| expr1              | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}") | Main filter expression                                   |
| expr2              | [System.Linq.Expressions.Expression{System.Func{\`\`1,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``1,System.Boolean}}") | Filter expression that filters on the navigated property |
| navigationProperty | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,``1}}")                                                                                | Expression to the navigation property (eg e => e.PropA.PropB) |

##### Generic Types

| Name | Description                                            |
| ---- | ------------------------------------------------------ |
| T    | Type of object in the main filter                      |
| TNav | Type of the navigation property (can be deeply nested) |

<a name='M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-Or``1-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>

### Or\`\`1(expr1,expr2) `method`

##### Summary

Adds another expression filter to original expression using Or operator

##### Returns

##### Parameters

| Name  | Type                                                                                                                                                                                                                                                                                                                                        | Description |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| expr1 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}") | Main filter expression                                                         |
| expr2 | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}") | Additional filter expression on the same type of object as the main expression |

##### Generic Types

| Name | Description                       |
| ---- | --------------------------------- |
| T    | Type of object in the main filter |

<a name='M-AndcultureCode-CSharp-Extensions-ExpressionExtensions-Or``2-System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``1,System-Boolean}},System-Linq-Expressions-Expression{System-Func{``0,``1}}-'></a>

### Or\`\`2(expr1,expr2,navigationProperty) `method`

##### Summary

Adds another expression filter to original expression using Or operator

##### Returns

##### Parameters

| Name               | Type                                                                                                                                                                                                                                                                                                                  | Description                                                   |
| ------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| expr1              | [System.Linq.Expressions.Expression{System.Func{\`\`0,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,System.Boolean}}") | Main filter expression                                   |
| expr2              | [System.Linq.Expressions.Expression{System.Func{\`\`1,System.Boolean}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``1,System.Boolean}}") | Filter expression that filters on the navigated property |
| navigationProperty | [System.Linq.Expressions.Expression{System.Func{\`\`0,\`\`1}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression "System.Linq.Expressions.Expression{System.Func{``0,``1}}")                                                                                | Expression to the navigation property (eg e => e.PropA.PropB) |

##### Generic Types

| Name | Description                                            |
| ---- | ------------------------------------------------------ |
| T    | Type of object in the main filter                      |
| TNav | Type of the navigation property (can be deeply nested) |

<a name='T-AndcultureCode-CSharp-Extensions-HttpRequestExtensions'></a>

## HttpRequestExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

Extension methods for HttpRequest

<a name='F-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-X_FORWARDED_FOR'></a>

### X_FORWARDED_FOR `constants`

##### Summary

Standard X-Header for forwarding IP addresses in varying infrastructures

<a name='M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-GetCookie-Microsoft-AspNetCore-Http-HttpRequest,System-String-'></a>

### GetCookie(request,name) `method`

##### Summary

Returns the specified cookie by name

If no cookie is found, returns null

##### Returns

##### Parameters

| Name    | Type                                                                                                                      | Description                           |
| ------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------- |
| request | [Microsoft.AspNetCore.Http.HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest "Microsoft.AspNetCore.Http.HttpRequest") | The request to pull the cookie from   |
| name    | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")   | The name of the cookie to be returned |

<a name='M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-GetHeader-Microsoft-AspNetCore-Http-HttpRequest,System-String-'></a>

### GetHeader(request,name) `method`

##### Summary

Attempts to retrieve requested header value

##### Parameters

| Name    | Type                                                                                                                      | Description     |
| ------- | ------------------------------------------------------------------------------------------------------------------------- | --------------- |
| request | [Microsoft.AspNetCore.Http.HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest "Microsoft.AspNetCore.Http.HttpRequest") |                 |
| name    | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")   | Header name/key |

<a name='M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-GetIpAddress-Microsoft-AspNetCore-Http-HttpRequest-'></a>

### GetIpAddress(request) `method`

##### Summary

Retrieves the client's forwarded IP address, if present. Returns null otherwise.
Ensure you have 'AddForwardedHeaders' enabled in startup.

##### Returns

##### Parameters

| Name    | Type                                                                                                                      | Description |
| ------- | ------------------------------------------------------------------------------------------------------------------------- | ----------- |
| request | [Microsoft.AspNetCore.Http.HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest "Microsoft.AspNetCore.Http.HttpRequest") |             |

<a name='M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-GetUserAgent-Microsoft-AspNetCore-Http-HttpRequest-'></a>

### GetUserAgent() `method`

##### Summary

Requesting user's agent

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-HttpRequestExtensions-HasCookie-Microsoft-AspNetCore-Http-HttpRequest,System-String-'></a>

### HasCookie(request,name) `method`

##### Summary

Returns whether or not the specified cookie is found in the request

If the cookie is found but its value is null/whitespace, it will return false.

##### Returns

##### Parameters

| Name    | Type                                                                                                                      | Description                         |
| ------- | ------------------------------------------------------------------------------------------------------------------------- | ----------------------------------- |
| request | [Microsoft.AspNetCore.Http.HttpRequest](#T-Microsoft-AspNetCore-Http-HttpRequest "Microsoft.AspNetCore.Http.HttpRequest") | The request to check for the cookie |
| name    | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")   | The name of the cookie to check for |

<a name='T-AndcultureCode-CSharp-Extensions-HttpResponseMessageExtensions'></a>

## HttpResponseMessageExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

HttpResponseMessage extension methods

<a name='M-AndcultureCode-CSharp-Extensions-HttpResponseMessageExtensions-FromJson``1-System-Net-Http-HttpResponseMessage-'></a>

### FromJson\`\`1(response) `method`

##### Summary

Deserializes http response into supplied object

##### Returns

##### Parameters

| Name     | Type                                                                                                                                                                                      | Description |
| -------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| response | [System.Net.Http.HttpResponseMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpResponseMessage "System.Net.Http.HttpResponseMessage") |             |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='T-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions'></a>

## IConfigurationRootExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

Extension methods for IConfigurationRoot

<a name='F-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-CONFIGURATION_VERSION_DEVELOPMENT_VALUE'></a>

### CONFIGURATION_VERSION_DEVELOPMENT_VALUE `constants`

##### Summary

Version value when application is run in development environment

<a name='F-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-CONFIGURATION_VERSION_KEY'></a>

### CONFIGURATION_VERSION_KEY `constants`

##### Summary

Key value for build version number

<a name='F-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-CONFIGURATION_VERSION_TEMPLATE'></a>

### CONFIGURATION_VERSION_TEMPLATE `constants`

##### Summary

Template string replaced with current version number

<a name='F-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-DEFAULT_DATABASE_KEY'></a>

### DEFAULT_DATABASE_KEY `constants`

##### Summary

Default connection string database key

<a name='M-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-GetDatabaseConnectionString-Microsoft-Extensions-Configuration-IConfigurationRoot,System-String-'></a>

### GetDatabaseConnectionString(configuration,databaseKey) `method`

##### Summary

Retrieves web application's primary database connection string

##### Parameters

| Name          | Type                                                                                                                                                                      | Description |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot "Microsoft.Extensions.Configuration.IConfigurationRoot") |             |
| databaseKey   | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                   |             |

<a name='M-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-GetDatabaseName-Microsoft-Extensions-Configuration-IConfigurationRoot-'></a>

### GetDatabaseName(configuration) `method`

##### Summary

Retrieves the database name of the primary database connection string

##### Parameters

| Name          | Type                                                                                                                                                                      | Description |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot "Microsoft.Extensions.Configuration.IConfigurationRoot") |             |

<a name='M-AndcultureCode-CSharp-Extensions-IConfigurationRootExtensions-GetVersion-Microsoft-Extensions-Configuration-IConfigurationRoot,System-Boolean-'></a>

### GetVersion(configuration,isDevelopment) `method`

##### Summary

Loads and conditionally updates the Version number based upon environment

##### Returns

##### Parameters

| Name          | Type                                                                                                                                                                      | Description |
| ------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot "Microsoft.Extensions.Configuration.IConfigurationRoot") |             |
| isDevelopment | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                |             |

<a name='T-AndcultureCode-CSharp-Extensions-IEnumerableExtensions'></a>

## IEnumerableExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

IEnumerable extension methods

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Except``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,System-Boolean}-'></a>

### Except\`\`1() `method`

##### Summary

Returns items in source collection that do not exist in exclusion collection based on predicate

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-HasValues``1-System-Collections-Generic-IEnumerable{``0}-'></a>

### HasValues\`\`1() `method`

##### Summary

Determines if the source collection is non-null and has values

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-HasValues``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}-'></a>

### HasValues\`\`1() `method`

##### Summary

Determines if the source collection is non-null and has values

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Intersect``1-System-Collections-Generic-IEnumerable{``0},System-Collections-Generic-IEnumerable{``0},System-Func{``0,``0,System-Boolean}-'></a>

### Intersect\`\`1() `method`

##### Summary

Returns items in source collection that exist in inclusion collection based on the predicate

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-IsEmpty``1-System-Collections-Generic-IEnumerable{``0}-'></a>

### IsEmpty\`\`1() `method`

##### Summary

Determines if the source list is empty

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-IsEmpty``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}-'></a>

### IsEmpty\`\`1() `method`

##### Summary

Determines if the source list is empty

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0}-'></a>

### IsNullOrEmpty\`\`1() `method`

##### Summary

Determines if the source list is null or empty

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0},System-Func{``0,System-Boolean}-'></a>

### IsNullOrEmpty\`\`1() `method`

##### Summary

Determines if the source list is null or empty

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Join-System-Collections-Generic-IEnumerable{System-String},System-String-'></a>

### Join() `method`

##### Summary

Convenience method so joining strings reads better :)

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Join-System-Collections-Generic-IEnumerable{System-Collections-Generic-KeyValuePair{System-String,System-String}},System-String,System-String-'></a>

### Join() `method`

##### Summary

Convenience method for joining dictionary key values into a string

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Join-System-Collections-Generic-List{System-String},System-String-'></a>

### Join() `method`

##### Summary

Convenience method so joining a list of strings

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Join-System-Collections-Generic-KeyValuePair{System-String,System-String},System-String-'></a>

### Join() `method`

##### Summary

Convenience method for joining key value pairs

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-PickRandom``1-System-Collections-Generic-IEnumerable{``0}-'></a>

### PickRandom\`\`1() `method`

##### Summary

Returns a random value in the related IEnumerable list

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-PickRandom``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>

### PickRandom\`\`1() `method`

##### Summary

Returns X number of random values in the related IEnumerable list

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IEnumerableExtensions-Shuffle``1-System-Collections-Generic-IEnumerable{``0}-'></a>

### Shuffle\`\`1() `method`

##### Summary

Returns source enumerable in randomized order

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Extensions-IQueryableExtensions'></a>

## IQueryableExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

IQueryable extension methods

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-AppendOrderByExpression``1-System-Linq-IQueryable{``0},System-String,AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection,System-Boolean-'></a>

### AppendOrderByExpression\`\`1(query,propertyName,direction,isAdditionalOrderBy) `method`

##### Summary

Adds an additional sorting expression to the supplied IQueryable.

##### Returns

##### Parameters

| Name                | Type                                                                                                                                                                                                          | Description                                                           |
| ------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------- |
| query               | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable "System.Linq.IQueryable{``0}") | The IQueryable to add additional sorting to. |
| propertyName        | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                       | The path to the property to order by (e.g. Path.To.Property).         |
| direction           | [RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection](#T-AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection "RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection")                        | Order by which to sort items.                                         |
| isAdditionalOrderBy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean "System.Boolean")                                                                                    | Whether the order by is an addition to an existing OrderBy statement. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-HasValues``1-System-Linq-IQueryable{``0}-'></a>

### HasValues\`\`1() `method`

##### Summary

Determines if the source collection is non-null and has values

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-HasValues``1-System-Linq-IQueryable{``0},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>

### HasValues\`\`1() `method`

##### Summary

Determines if the source collection is non-null and has values

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-IsEmpty``1-System-Linq-IQueryable{``0}-'></a>

### IsEmpty\`\`1() `method`

##### Summary

Determines if the source list is empty

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-IsEmpty``1-System-Linq-IQueryable{``0},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>

### IsEmpty\`\`1() `method`

##### Summary

Determines if the source list is empty (based on the given predicate)

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-IsNullOrEmpty``1-System-Linq-IQueryable{``0}-'></a>

### IsNullOrEmpty\`\`1() `method`

##### Summary

Determines if the source list is null or empty

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-IsNullOrEmpty``1-System-Linq-IQueryable{``0},System-Linq-Expressions-Expression{System-Func{``0,System-Boolean}}-'></a>

### IsNullOrEmpty\`\`1() `method`

##### Summary

Determines if the source list is null or empty (based on the given predicate)

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-OrderBy``1-System-Linq-IQueryable{``0},System-String,AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection-'></a>

### OrderBy\`\`1(query,propertyName,direction) `method`

##### Summary

Order by the string expression provided.

##### Returns

##### Parameters

| Name         | Type                                                                                                                                                                                                                 | Description                                                   |
| ------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| query        | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable "System.Linq.IQueryable{``0}") | The IOrderedQueryable to add additional sorting to. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                              | The path to the property to order by (e.g. Path.To.Property). |
| direction    | [RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection](#T-AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection "RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection")                               | Order by which to sort items.                                 |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-PickRandom``1-System-Linq-IQueryable{``0}-'></a>

### PickRandom\`\`1(source) `method`

##### Summary

Returns a random value in the related IQueryable list

##### Parameters

| Name   | Type                                                                                                                                                           | Description |
| ------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------- |
| source | [System.Linq.IQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IQueryable "System.Linq.IQueryable{``0}") |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-PickRandom``1-System-Linq-IQueryable{``0},System-Int32-'></a>

### PickRandom\`\`1() `method`

##### Summary

Returns X number of random values in the related IQueryable list

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-Shuffle``1-System-Linq-IQueryable{``0}-'></a>

### Shuffle\`\`1() `method`

##### Summary

Returns source enumerable in randomized order

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-IQueryableExtensions-ThenBy``1-System-Linq-IOrderedQueryable{``0},System-String,AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection-'></a>

### ThenBy\`\`1(query,propertyName,direction) `method`

##### Summary

Order then by the string expression provided.

##### Returns

##### Parameters

| Name         | Type                                                                                                                                                                                                                                      | Description                                                   |
| ------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| query        | [System.Linq.IOrderedQueryable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IOrderedQueryable "System.Linq.IOrderedQueryable{``0}") | The IOrderedQueryable to add additional sorting to. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String")                                                                                                                   | The path to the property to order by (e.g. Path.To.Property). |
| direction    | [RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection](#T-AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection "RSM.HCD.CSharp.Extensions.Enumerations.OrderByDirection")                                                    | Order by which to sort items.                                 |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T    |             |

<a name='T-AndcultureCode-CSharp-Extensions-Models-LambdaComparer`1'></a>

## LambdaComparer\`1 `type`

##### Namespace

RSM.HCD.CSharp.Extensions.Models

##### Summary

Generic comparator class for ease of use with comparison functions

<a name='M-AndcultureCode-CSharp-Extensions-Models-LambdaComparer`1-#ctor-System-Func{`0,`0,System-Boolean}-'></a>

### #ctor(predicate) `constructor`

##### Summary

Constructor for new comparator based on predicate

##### Parameters

| Name      | Type                                                                                                                                                            | Description                                  |
| --------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------- |
| predicate | [System.Func{\`0,\`0,System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func "System.Func{`0,`0,System.Boolean}") | Predicate to be used for equality comparison |

<a name='M-AndcultureCode-CSharp-Extensions-Models-LambdaComparer`1-Equals-`0,`0-'></a>

### Equals() `method`

##### Summary

_Inherit from parent._

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-Models-LambdaComparer`1-GetHashCode-`0-'></a>

### GetHashCode() `method`

##### Summary

_Inherit from parent._

##### Parameters

This method has no parameters.

<a name='T-AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection'></a>

## OrderByDirection `type`

##### Namespace

RSM.HCD.CSharp.Extensions.Enumerations

##### Summary

Directions for ordering items.

<a name='F-AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection-Ascending'></a>

### Ascending `constants`

##### Summary

Sorted in ascending order.

<a name='F-AndcultureCode-CSharp-Extensions-Enumerations-OrderByDirection-Descending'></a>

### Descending `constants`

##### Summary

Sorted in descending order.

<a name='T-AndcultureCode-CSharp-Extensions-StringExtensions'></a>

## StringExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

String extension methods

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-AsIndentedJson-System-String-'></a>

### AsIndentedJson(str) `method`

##### Summary

Formats string for pretty printing of a JSON string

##### Returns

##### Parameters

| Name | Type                                                                                                                    | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| str  | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-IsInvalidHttpUrl-System-String-'></a>

### IsInvalidHttpUrl(source) `method`

##### Summary

Determines if the supplied string is not a valid HTTP or HTTPS Url

Uses the native Uri class

##### Returns

##### Parameters

| Name   | Type                                                                                                                    | Description |
| ------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-IsNotValidGuid-System-String-'></a>

### IsNotValidGuid(guidString) `method`

##### Summary

Determine if supplied string is not a valid Guid

##### Returns

##### Parameters

| Name       | Type                                                                                                                    | Description |
| ---------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| guidString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-IsValidEmail-System-String-'></a>

### IsValidEmail(email) `method`

##### Summary

Determines if the supplied string is an email address

##### Parameters

| Name  | Type                                                                                                                    | Description |
| ----- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-IsValidGuid-System-String-'></a>

### IsValidGuid(guidString) `method`

##### Summary

Determine if supplied string is a valid Guid

##### Returns

##### Parameters

| Name       | Type                                                                                                                    | Description |
| ---------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| guidString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-IsValidHttpUrl-System-String-'></a>

### IsValidHttpUrl(source) `method`

##### Summary

Determines if the supplied string is a valid HTTP or HTTPS url

Uses the native Uri class

##### Parameters

| Name   | Type                                                                                                                    | Description |
| ------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-ToBoolean-System-String-'></a>

### ToBoolean() `method`

##### Summary

Converts a string representation of a boolean into an actual boolean

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-ToEnumerable``1-System-String,System-Char-'></a>

### ToEnumerable\`\`1(input,separator) `method`

##### Summary

Converts a string of ints into an enumerable

##### Returns

##### Parameters

| Name      | Type                                                                                                                    | Description |
| --------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| input     | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |
| separator | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char "System.Char")       |             |

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-ToInt-System-String,System-Int32-'></a>

### ToInt(number,defaultValue) `method`

##### Summary

Convert a string to integer, otherwise default the value

##### Returns

Converted string as an integer value

##### Parameters

| Name         | Type                                                                                                                    | Description                                                     |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------- |
| number       | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") | String that should be a number                                  |
| defaultValue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 "System.Int32")    | Default value used if the number cannot be parse (0 is default) |

<a name='M-AndcultureCode-CSharp-Extensions-StringExtensions-TryChangeType-System-Object,System-Type-'></a>

### TryChangeType(value,conversionType) `method`

##### Summary

Returns true or false if the value can be converted

##### Returns

##### Parameters

| Name           | Type                                                                                                                    | Description |
| -------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| value          | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object "System.Object") |             |
| conversionType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type "System.Type")       |             |

<a name='T-AndcultureCode-CSharp-Extensions-TypeExtensions'></a>

## TypeExtensions `type`

##### Namespace

RSM.HCD.CSharp.Extensions

##### Summary

Extensions for Type

<a name='M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetPublicConstantValues``1-System-Type-'></a>

### GetPublicConstantValues\`\`1() `method`

##### Summary

Retrieve all constant values for given type whose value matches type T

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetPublicPropertyInfo-System-Type,System-String-'></a>

### GetPublicPropertyInfo(type,propertyName) `method`

##### Summary

Get the PropertyInfo for specified property,
if it exists on the type and is public,
otherwise returns null.

##### Returns

The PropertyInfo for the property, if it exists and is public, null otherwise.

##### Parameters

| Name         | Type                                                                                                                    | Description |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| type         | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type "System.Type")       |             |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetPublicPropertyValue-System-Object,System-String-'></a>

### GetPublicPropertyValue(src,propertyName) `method`

##### Summary

Get the value of a property specified by propertyName,
if it exists on the object and is public.
If no such public property exists, returns null.

##### Returns

The property value, if it exists and is public, null otherwise.

##### Parameters

| Name         | Type                                                                                                                    | Description |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| src          | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object "System.Object") |             |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetPublicPropertyValue``1-System-Object,System-String-'></a>

### GetPublicPropertyValue\`\`1(src,propertyName) `method`

##### Summary

Get the value of a property specified by propertyName,
if it exists on the object and is public, casted to type T.
If no such property exists, returns null.

##### Returns

The property value, if it exists, null otherwise.

##### Parameters

| Name         | Type                                                                                                                    | Description |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| src          | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object "System.Object") |             |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetTypeName-System-Object-'></a>

### GetTypeName(obj) `method`

##### Summary

Returns the name the underlying type of any object

##### Returns

##### Parameters

| Name | Type                                                                                                                    | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| obj  | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object "System.Object") |             |

<a name='M-AndcultureCode-CSharp-Extensions-TypeExtensions-GetTypeName-System-Type-'></a>

### GetTypeName(type) `method`

##### Summary

Returns the full name of the type as well as the assembly qualified name

##### Returns

##### Parameters

| Name | Type                                                                                                              | Description |
| ---- | ----------------------------------------------------------------------------------------------------------------- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type "System.Type") |             |

<a name='M-AndcultureCode-CSharp-Extensions-TypeExtensions-HasPublicProperty-System-Type,System-String-'></a>

### HasPublicProperty(type,propertyName) `method`

##### Summary

Checks whether a property specified by propertyName exists
on the specified type.

##### Returns

true if type has property with specified name, false otherwise

##### Parameters

| Name         | Type                                                                                                                    | Description |
| ------------ | ----------------------------------------------------------------------------------------------------------------------- | ----------- |
| type         | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type "System.Type")       |             |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String "System.String") |             |

<a name='M-AndcultureCode-CSharp-Extensions-TypeExtensions-WhereWithAttribute``1-System-Collections-Generic-IEnumerable{System-Type}-'></a>

### WhereWithAttribute\`\`1() `method`

##### Summary

Filters the provided list of types to only those that are
decorated with the TAttribute attribute at the class level.

##### Parameters

This method has no parameters.

<a name='M-AndcultureCode-CSharp-Extensions-TypeExtensions-WhereWithoutAttribute``1-System-Collections-Generic-IEnumerable{System-Type}-'></a>

### WhereWithoutAttribute\`\`1() `method`

##### Summary

Filters the provided list of types to only those that aren't
decorated with the TAttribute attribute at the class level.

##### Parameters

This method has no parameters.
