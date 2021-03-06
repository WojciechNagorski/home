# [ExtendedXmlSerializer v3.3.0](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.3.0)
> 09/22/2020 06:05:26 UTC
##### ``v3.3.0``
### ✨ New Features &#128640; 
- Introduced type-based serialization interception. #452 @Mike-E-angelo 

# [ExtendedXmlSerializer v3.2.7](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.2.7)
> 09/15/2020 13:28:08 UTC
##### ``v3.2.7``
### &#128027; Bug Fixes &#128295; 
- Accounted for empty CDATA elements. #444 @Mike-E-angelo 
- Accounted for successive CDATA blocks. #448 @Mike-E-angelo 

# [ExtendedXmlSerializer v3.2.6](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.2.6)
> 09/01/2020 08:58:59 UTC
##### ``v3.2.6``
### &#128027; Bug Fixes &#128295; 
- Allowed `null` Namespace for Framework Types #430 @oliver-chime 
- Allowed `null`/Empty Namespaces for Custom/Non-system Assemblies #432 @Mike-E-angelo 
- Removed Caching from Reference Resolution #437 @Mike-E-angelo 

# [ExtendedXmlSerializer v3.2.5](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.2.5)
> 08/18/2020 07:24:58 UTC
##### ``v3.2.5``
### &#128027; Bug Fixes &#128295; 
- Accounted for rare state when namespace prefix is `null`. #424 @Mike-E-angelo 
- Improved member resolution for parameterized content #428 @Mike-E-angelo 

# [ExtendedXmlSerializer v3.2.4](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.2.4)
> 07/21/2020 17:47:55 UTC
##### ``v3.2.4``
### &#128027; Bug Fixes &#128295; 
- Member resolution now uses ReflectedType first, then DeclaredType. #417 @Mike-E-wins 
- Fixed references resolution bugs during deserialization #420 @Mike-E-wins 
- Added support for IReadOnlyList properties. #421 @Mike-E-wins 

# [ExtendedXmlSerializer v3.2.3](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.2.3)
> 07/21/2020 14:12:24 UTC
##### ``v3.2.3``
### &#128027; Bug Fixes &#128295; 
- Assigned parser contexts for migrations. #415 @Mike-E-wins 

# [ExtendedXmlSerializer v3.2.2](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.2.2)
> 07/07/2020 07:25:26 UTC
##### ``v3.2.2``
### &#128027; Bug Fixes &#128295; 
- Enabled member comparison by base-type on EmitWhen call. #412 @Mike-E-wins 

# [ExtendedXmlSerializer v3.2.1](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.2.1)
> 06/22/2020 14:51:17 UTC
##### ``v3.2.1``
### &#128027; Bug Fixes &#128295; 
- Fixed bug with references w/ exs:member=&quot;&quot; attributes #408 @Mike-E-wins 

# [ExtendedXmlSerializer v3.2.0](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.2.0)
> 06/16/2020 07:28:35 UTC
##### ``v3.2.0``
### ✨ New Features &#128640; 
- Allowed members to be configured from base classes. #399 @Mike-E-wins 
- Ensured exs xmlns is applied to root for optimized namespace + enabled-reference scenarios. #402 @Mike-E-wins 
### &#128027; Bug Fixes &#128295; 
- Demonstrated WithUnknownContent().Continue() #395 @Mike-E-wins 
- Adjusted reference detection to be more accurate in the case of attri… #400 @Mike-E-wins 
### Other Changes 
- Added basic (throw) support for anonymous/dynamic types. #389 @Mike-E-wins 
- [Automated] Generated CHANGELOG.md #390 @github-actions[bot] 
- Emit initialization times. #394 @Mike-E-wins 
- Sample code for documentation demonstrating implicit and explicit ref… #404 @Mike-E-wins 

# [ExtendedXmlSerializer v3.1.4](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.1.4)
> 04/28/2020 06:37:20 UTC
##### ``v3.1.4``
### &#128027; Bug Fixes &#128295; 
- Added support for Flags-based enumerations. #387 @Mike-E-wins 

# [ExtendedXmlSerializer v3.1.3](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.1.3)
> 03/25/2020 12:57:39 UTC
##### ``v3.1.3``
### &#128027; Bug Fixes &#128295; 
- Added test demonstrating private setters. #376 @Mike-EEE 
- Fixed Caching Issues for Better Performance. #381 @Mike-EEE 
### Other Changes 
- Added Sample code for question. #373 @Mike-EEE 

# [ExtendedXmlSerializer v3.1.2](https://github.com/ExtendedXmlSerializer/home/releases/tag/v3.1.2)
> 02/07/2020 09:56:47 UTC
##### ``v3.1.2``
### &#128027; Bug Fixes &#128295; 
- Adjusted assembly-loading to be a bit more robust for .NETFramework-b… #367 @Mike-EEE 

# [ExtendedXmlSerializer v3.1.1](https://github.com/ExtendedXmlSerializer/home/releases/tag/3.1.1)
> 01/30/2020 15:29:34 UTC
##### ``3.1.1``
### &#128027; Bug Fixes &#128295;

  - Accounted for struct root instances when references are enabled. #359 @Mike-EEE 
  - Removed recursion check for types that have custom serializers defin… #362 @Mike-EEE / @aspektxxx 
# [ExtendedXmlSerializer v3.1.0](https://github.com/ExtendedXmlSerializer/home/releases/tag/3.1.0)
> 01/18/2020 06:18:13 UTC
##### ``3.1.0``
### ✨ New Features &#128640;

  - Added basic support for IEnumerable&lt;T&gt; for both instance and member property definitions. #343 @Mike-EEE 
  - Added additional testing around Enumerable property support. #344 @Mike-EEE 
  - Further adjusted and improved type content composer API. #351 @Mike-EEE 
  - Further improved serializer registration #353 @Mike-EEE 
  
### &#128027; Bug Fixes &#128295;
  
  - Removed attribute values from reference-based reading. #342 @Mike-EEE 
  - Added ordering to parameterized content members. #356 @Mike-EEE 
  - Fixed type resolution issue with conflicting member name having the... #354 @Mike-EEE 
  
### Other Changes
  
  - Updated nuget reference for NReco.LambdaParser. #347 @Mike-EEE 
  - Improved content serializer composition API. #350 @Mike-EEE 
  - Added example code. #348 @Mike-EEE 

# [ExtendedXmlSerializer v3.0.2](https://github.com/ExtendedXmlSerializer/home/releases/tag/3.0.2)
> 12/10/2019 08:28:04 UTC
##### ``3.0.2``
A patch release that addresses reported issues since the 3.0.0 release.
### &#128027; Bug Fixes &#128295; 
- Fixed bug with null arrays when EmitBehaviors.WhenModified is used. #338 @Mike-EEE 
### Other Changes 
- Updated NuGet references. #336 @Mike-EEE 

# [ExtendedXmlSerializer v3.0.1](https://github.com/ExtendedXmlSerializer/home/releases/tag/3.0.1)
> 12/03/2019 10:09:25 UTC
##### ``3.0.1``
Every major release has one. &#128517; This minor patch fixing release is basically ironing out identified issues found during the deployment process of version `3.0.0`.

### Other Changes
- Fixed deployment issues #334 @Mike-EEE
# [ExtendedXmlSerializer v3.0.0](https://github.com/ExtendedXmlSerializer/home/releases/tag/3.0.0)
> 12/03/2019 07:15:01 UTC
##### ``3.0.0``
This is our first release that makes use of NextRelease (https://www.nextrelease.io/)

As such, starting with this release we aim to incorporate better release notes, as well as adhere to Semantic Versioning in a more disciplined manner.  Unfortunately, we incorporated NextRelease after work began on this release, so we&#39;re missing some issues generated by NextRelease in this copy, so we&#39;ll make mention of them here in this summary.

The first being that we have some breaking changes with this release, which you can see in this issue:
https://github.com/ExtendedXmlSerializer/home/issues/289

Secondly, I&#39;m happy to announce that we have a _bunch_ of documentation now!  I&#39;ve been spending the past few weeks slogging through the necessary (and painful &#128517;) brain dump required to get the information stored in my noggin over this project into words that can be digested by others.

To start, we have all the publicly-exposed API members documented in XML format throughout the project. #189

We also have our wiki nicely rounded out, complete with examples and API overview:
https://github.com/ExtendedXmlSerializer/home/wiki

But that&#39;s not all. &#128513;  We now have a documentation site that is deployed on every release, generated by [DocFX](https://dotnet.github.io/docfx/):
https://extendedxmlserializer.github.io/documentation/

It also contains API reference (generated by our XML documentation in source):
https://extendedxmlserializer.github.io/documentation/reference/

And conceptual documentation (which is a mirror of our wiki):
https://extendedxmlserializer.github.io/documentation/conceptual/

Third (and finally!), it is worth mentioning that we have a new home and URL as you can see in the provided links throughout the summary and can be found here:

https://github.com/ExtendedXmlSerializer/home/

Please update any git references you have to our new location on the GitHubs.

Before closing out, I would like to personally thank @WojciechNagorski for being so gracious in passing off the keys to his baby to me (@Mike-EEE).   It has enabled us to take the next step here with ExtendedXmlSerializer, and to round out a few of the missing pieces as described above.   @WojciechNagorski will still be involved, but we both decided that it would be best if I take over the reigns to this project, as it basically has been mine since v2 began.  Needless to say, it&#39;s been a well-accepted learning lesson for us both.

With that, I would like to sign off on this release and send a BIG thank you to everyone who has supported and uses ExtendedXmlSerializer!

### &#128165; Breaking Changes &#128561;

- Upgraded minimum .NET version to 4.5.2 #331 @Mike-EEE

### Other Changes

- Incorporated workflow and GitHub Actions work from NextRelease Repo #314 @Mike-EEE
- Updated links to /home/ and improved Nuget package information. #316 @Mike-EEE
- Updated documentation site&#39;s theme and style. #317 @Mike-EEE
- Fixed link to CHANGELOG in Nuget Packaging #320 @Mike-EEE
- Updated README and fixed lists in documentation. #321 @Mike-EEE
- Added Passing Tests for Documentation Examples #322 @Mike-EEE
- Added tests demonstrating extension scenario for documentation. #323 @Mike-EEE
- Providing a monitor example for documentation. #325 @Mike-EEE
- Provided code used for README. #326 @Mike-EEE
- Added tests for demonstrating configuration profiles in documentation. #327 @Mike-EEE
- Added code/documentation example for converters. #329 @Mike-EEE
- Updated submodule reference. #330 @Mike-EEE
- Modified Build Solution to Include Other Projects #332 @Mike-EEE
- Removed dependency to System.Reflection.Emit.Lightweight. #319 @Mike-EEE

