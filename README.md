# Apprenda-Azure
This contains the source needed to provision / deprovision Microsoft Azure resources.
Release Notes
--------------

### Support Matrix
Apprenda Cloud Platform 6.0.3+, 6.5.x
AWS SDK version is bundled with each stable release.

Automatic regression Tests are done against new versions of the AWS SDK, which is released on a more frequent cadence. If you need to use the latest version, build the package from source.

Installation
------------
_For full documentation on how to setup Addons on the Apprenda Cloud Platform, please read [here]()_
- Download our latest [release]()
- Upload the zip file for the component you need. For example, if you need S3, then upload the S3.zip file.
- You should see a screen like this, stating validation was successful.

Configuration
-------------
_For general documentation on how to setup Addons on the Apprenda Cloud Platform, please read [here]()_

#### To be added

Usage
-----

#### To be added

Build From source
-----------------
- `git clone`, open .Sln in Visual Studio (or equivalent)
- `nuget restore` or from the Package Manager in Visual Studio, `Update-Package`
- If you have a private NuGet repository with the Apprenda SDK (`SaaSGrid.API`) included, then skip to the build step. If you do not:
  - Install the [Apprenda SDK]() for the version of Cloud Platform you are currently running
  - Locate `SaaSGrid.API` in your installation folder (Typical installation will have it at `C:\Program Files (x86)\Apprenda\SDK\API Files`)
  - Use this path to add a new reference to `SaaSGrid.API`
- Build - upon success, you should have a folder in the root project directory named `Apprenda-AWS-Build` with access to each of the zip files.

Support
-------
For support on this addon, please feel free to submit an issue - we'll look into it right away.

For support regarding Apprenda Cloud platform - please contact your representative or shoot us an email at support@apprenda.com

Contributions
-------------
Are absolutely welcome, please fork and submit PRs. We run our own internal test suite on each PR, and will let you know the results!
