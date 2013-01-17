# TransferGuardConsoleApplication
PAML TransferGuard Web Service Sample C# Console Application

This sample demonstrates how use the PAML TransferGuard Web Service to send laboratory orders and receive results.  You must be a Pathology Associates Medical Laboratories, LLC (PAML) client or 
approved vendor to access the TransferGuard Web Services.  Visit http://www.paml.com/ for more information.

# Getting Started
1. Git the code from https://github.com/PAML/TransferGuardConsoleApplication
2. Import your TransferGuard client certificate
   * Double-click the .p12 certificate you received from PAML
   * Enter the password for the certificate
   * Select the option to 'Automatically select the certificate store based on the type of certificate'
   * Allow the PAML TrasnferGuard Certificate Authority to be installed
3. Open the project in Visual Studio
4. Change SiteId to the site ID provided by PAML and included in your certificate
5. Press F5 to build and run a debug version of the sample application

# FAQ
1. I am getting the following error:
Q:
<blockquote>
There was an error downloading 'https://transferguard-cert.paml.com/v1/wsdl/TransferService.wsdl'. 
The request was aborted: Could not create SSL/TLS secure channel. Metadata contains a reference that cannot be resolved: 'https://transferguard-cert.paml.com/v1/wsdl/TransferService.wsdl'.
Could not establish secure channel for SSL/TLS with authority 'transferguard-cert.paml.com<http://transferguard-cert.paml.com>'.
The request was aborted: Could not create SSL/TLS secure channel.
If the service is defined in the current solution, try building the solution and adding the service reference again.
</blockquote>
A:
Make sure that the web service references and config are in both the service project and any other calling projects. See [here](http://stackoverflow.com/a/2737593/27657) for more information.


# Need Help?
Support and other information is available at https://github.com/PAML/.
