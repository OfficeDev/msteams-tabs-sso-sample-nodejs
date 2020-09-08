#pragma checksum "C:\Dev\GitHub\msteams-tabs-sso-sample-nodejs\src\dotnet\Views\Auth\authStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "359a3be1ff351ac2cc709e8eca70b0a33b0ffbca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_authStart), @"mvc.1.0.view", @"/Views/Auth/authStart.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Dev\GitHub\msteams-tabs-sso-sample-nodejs\src\dotnet\Views\_ViewImports.cshtml"
using msteams_tabs_sso_sample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\GitHub\msteams-tabs-sso-sample-nodejs\src\dotnet\Views\_ViewImports.cshtml"
using msteams_tabs_sso_sample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"359a3be1ff351ac2cc709e8eca70b0a33b0ffbca", @"/Views/Auth/authStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9972ec5bc2a9f9acd9fdbe738d10977be341f588", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_authStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Dev\GitHub\msteams-tabs-sso-sample-nodejs\src\dotnet\Views\Auth\authStart.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "359a3be1ff351ac2cc709e8eca70b0a33b0ffbca3517", async() => {
                WriteLiteral("\r\n    <title>Auth Start Page</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "359a3be1ff351ac2cc709e8eca70b0a33b0ffbca4521", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 130, "\"", 207, 2);
                WriteAttributeValue("", 136, "https://unpkg.com/", 136, 18, true);
                WriteLiteral("@");
                WriteAttributeValue("", 156, "microsoft/teams-js@1.5.0/dist/MicrosoftTeams.min.js", 156, 51, true);
                EndWriteAttribute();
                WriteLiteral(@" crossorigin=""anonymous""></script>
    <script src=""https://secure.aadcdn.microsoftonline-p.com/lib/1.0.15/js/adal.min.js"" integrity=""sha384-lIk8T3uMxKqXQVVfFbiw0K/Nq+kt1P3NtGt/pNexiDby2rKU6xnDY8p16gIwKqgI"" crossorigin=""anonymous""></script>

    <script>
        microsoftTeams.initialize();
        // Get the tab context, and use the information to navigate to Azure AD login page
        microsoftTeams.getContext(function (context) {
            // Generate random state string and store it, so we can verify it in the callback
            let state = _guid();
            localStorage.setItem(""auth.state"", state);
            localStorage.removeItem(""auth.error"");
            // See https://docs.microsoft.com/en-us/azure/active-directory/develop/active-directory-v2-protocols-implicit
            // for documentation on these query parameters
            let queryParams = {
                client_id: ""#{clientId}"",
                response_type: ""id_token token"",
                response_mode: ""f");
                WriteLiteral(@"ragment"",
                scope: ""https://graph.microsoft.com/User.Read email openid profile offline_access"",
                redirect_uri: window.location.origin + ""/auth/auth-end"",
                nonce: _guid(),
                state: state,
                login_hint: context.loginHint,
            };
            // Go to the AzureAD authorization endpoint (tenant-specific endpoint, not ""common"")
            // For guest users, we want an access token for the tenant we are currently in, not the home tenant of the guest. 
            let authorizeEndpoint = `https://login.microsoftonline.com/${context.tid}/oauth2/v2.0/authorize?${toQueryString(queryParams)}`;
            window.location.assign(authorizeEndpoint);
        });
        // Build query string from map of query parameter
        function toQueryString(queryParams) {
            let encodedQueryParams = [];
            for (let key in queryParams) {
                encodedQueryParams.push(key + ""="" + encodeURIComponent(queryParams");
                WriteLiteral(@"[key]));
            }
            return encodedQueryParams.join(""&"");
        }
        // Converts decimal to hex equivalent
        // (From ADAL.js: https://github.com/AzureAD/azure-activedirectory-library-for-js/blob/dev/lib/adal.js)
        function _decimalToHex(number) {
            var hex = number.toString(16);
            while (hex.length < 2) {
                hex = '0' + hex;
            }
            return hex;
        }
        // Generates RFC4122 version 4 guid (128 bits)
        // (From ADAL.js: https://github.com/AzureAD/azure-activedirectory-library-for-js/blob/dev/lib/adal.js)
        function _guid() {
            // RFC4122: The version 4 UUID is meant for generating UUIDs from truly-random or
            // pseudo-random numbers.
            // The algorithm is as follows:
            //     Set the two most significant bits (bits 6 and 7) of the
            //        clock_seq_hi_and_reserved to zero and one, respectively.
            //     Set the four most ");
                WriteLiteral(@"significant bits (bits 12 through 15) of the
            //        time_hi_and_version field to the 4-bit version number from
            //        Section 4.1.3. Version4
            //     Set all the other bits to randomly (or pseudo-randomly) chosen
            //     values.
            // UUID                   = time-low ""-"" time-mid ""-""time-high-and-version ""-""clock-seq-reserved and low(2hexOctet)""-"" node
            // time-low               = 4hexOctet
            // time-mid               = 2hexOctet
            // time-high-and-version  = 2hexOctet
            // clock-seq-and-reserved = hexOctet:
            // clock-seq-low          = hexOctet
            // node                   = 6hexOctet
            // Format: xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx
            // y could be 1000, 1001, 1010, 1011 since most significant two bits needs to be 10
            // y values are 8, 9, A, B
            var cryptoObj = window.crypto || window.msCrypto; // for IE 11
            if (crypto");
                WriteLiteral(@"Obj && cryptoObj.getRandomValues) {
                var buffer = new Uint8Array(16);
                cryptoObj.getRandomValues(buffer);
                //buffer[6] and buffer[7] represents the time_hi_and_version field. We will set the four most significant bits (4 through 7) of buffer[6] to represent decimal number 4 (UUID version number).
                buffer[6] |= 0x40; //buffer[6] | 01000000 will set the 6 bit to 1.
                buffer[6] &= 0x4f; //buffer[6] & 01001111 will set the 4, 5, and 7 bit to 0 such that bits 4-7 == 0100 = ""4"".
                //buffer[8] represents the clock_seq_hi_and_reserved field. We will set the two most significant bits (6 and 7) of the clock_seq_hi_and_reserved to zero and one, respectively.
                buffer[8] |= 0x80; //buffer[8] | 10000000 will set the 7 bit to 1.
                buffer[8] &= 0xbf; //buffer[8] & 10111111 will set the 6 bit to 0.
                return _decimalToHex(buffer[0]) + _decimalToHex(buffer[1]) + _decimalToHex(buffer[2]) + _");
                WriteLiteral(@"decimalToHex(buffer[3]) + '-' + _decimalToHex(buffer[4]) + _decimalToHex(buffer[5]) + '-' + _decimalToHex(buffer[6]) + _decimalToHex(buffer[7]) + '-' +
                    _decimalToHex(buffer[8]) + _decimalToHex(buffer[9]) + '-' + _decimalToHex(buffer[10]) + _decimalToHex(buffer[11]) + _decimalToHex(buffer[12]) + _decimalToHex(buffer[13]) + _decimalToHex(buffer[14]) + _decimalToHex(buffer[15]);
            }
            else {
                var guidHolder = 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx';
                var hex = '0123456789abcdef';
                var r = 0;
                var guidResponse = """";
                for (var i = 0; i < 36; i++) {
                    if (guidHolder[i] !== '-' && guidHolder[i] !== '4') {
                        // each x and y needs to be random
                        r = Math.random() * 16 | 0;
                    }
                    if (guidHolder[i] === 'x') {
                        guidResponse += hex[r];
                    } else if (guidHolder");
                WriteLiteral(@"[i] === 'y') {
                        // clock-seq-and-reserved first hex is filtered and remaining hex values are random
                        r &= 0x3; // bit and with 0011 to set pos 2 to zero ?0??
                        r |= 0x8; // set pos 3 to 1 as 1???
                        guidResponse += hex[r];
                    } else {
                        guidResponse += guidHolder[i];
                    }
                }
                return guidResponse;
            }
        };
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591