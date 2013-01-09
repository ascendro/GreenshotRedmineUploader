GreenshotRedmineUploader
==============

Little helper tool which can be configured in the Greenshot Screen Capture Software and uploads Screen Captures directly into redmine.

## Installation

The tool can be used as standalone and doesnt need an installation. Still theres some configuration 
necessary to integrate it into Greenshot.

Compile or place the executable from GreenshotRedmineUploader/bin/...exe on a suitable place on your computer.
(Dont forget the DLL file Redmine.Net.Api.dll - it has to stay next to the executable)
Configure the "External command Plugin" and add a new Item "RedmineUploader" with the following settings:

Command: Path to the executable

Argument: "{0}"

Then when the tool is started first time the Redmine Server and APIKey has to be inserted into the settings.
It is not needed for issue updates but for creation of issues and changing priorities, states etc a Redmine Sync should 
be done (Button in the Settings).

It is downloading a Project List and other Informations for the Drop Down Lists. This will be cached on the Computer in
order to make the process faster. 
A Syncronisation can be rerun all the time in order to get new updates.

Thats it. The tool is ready to use.

## Used Library

This tool is using the redmine-net-api (https://code.google.com/p/redmine-net-api/) - SVN Revision 110.

## License

   Copyright Michael Kling - Ascendro S.R.L

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.

## Changelog

### 0.0.1

 - initial release
 
### 0.0.2

 - Small fixes
 - Add a file description
 - Comment on old issue
 - Issue ID input now with select box
 - Select Boxes are sorted and have autosearch