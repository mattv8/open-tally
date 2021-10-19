# ![OpenTally Icon](https://git.visnovsky.us/Matt/open-tally/-/raw/master/icons/Icon-02.png) Welcome to Open Tally!
![ot+ta.png](https://github.com/mattv8/open-tally/blob/main/icons/ot+ta.png?raw=true) OpenTally works with [TallyArbiter](https://github.com/josephdadams/TallyArbiter/)!

OpenTally is an open-source Windows .NET framework app with three primary purposes: 

 1. To bring functionality between Joseph Adam's [TallyArbiter](https://github.com/josephdadams/TallyArbiter/) app with which tally bus data can be sent via USB to the [OpenTally USB Client]():

[![](https://mermaid.ink/img/eyJjb2RlIjoiZ3JhcGggTFJcbkEoVGFsbHlBcmJpdGVyKSAtLSBTb2NrZXRJTyAtLT4gQigoT3BlblRhbGx5KSkgLS0gVVNCIC0tPiBDW09wZW5UYWxseSBVU0IgQ2xpZW50XSIsIm1lcm1haWQiOnsidGhlbWUiOiJkZWZhdWx0In0sInVwZGF0ZUVkaXRvciI6ZmFsc2UsImF1dG9TeW5jIjp0cnVlLCJ1cGRhdGVEaWFncmFtIjpmYWxzZX0)](https://mermaid-js.github.io/mermaid-live-editor/edit/#eyJjb2RlIjoiZ3JhcGggTFJcbkEoVGFsbHlBcmJpdGVyKSAtLSBTb2NrZXRJTyAtLT4gQigoT3BlblRhbGx5KSkgLS0gVVNCIC0tPiBDW09wZW5UYWxseSBVU0IgQ2xpZW50XSIsIm1lcm1haWQiOiJ7XG4gIFwidGhlbWVcIjogXCJkZWZhdWx0XCJcbn0iLCJ1cGRhdGVFZGl0b3IiOmZhbHNlLCJhdXRvU3luYyI6dHJ1ZSwidXBkYXRlRGlhZ3JhbSI6ZmFsc2V9)

2. To communicate directly with OBS Websockets for tally bus information which can be sent over USB to the [OpenTally USB Client]():

[![](https://mermaid.ink/img/eyJjb2RlIjoiZ3JhcGggTFJcbkEoT0JTKSAtLSBPQlMgV2Vic29ja2V0cyAtLT4gQigoT3BlblRhbGx5KSkgLS0gVVNCIC0tPiBDW09wZW5UYWxseSBVU0IgQ2xpZW50XSIsIm1lcm1haWQiOnsidGhlbWUiOiJkZWZhdWx0In0sInVwZGF0ZUVkaXRvciI6ZmFsc2UsImF1dG9TeW5jIjp0cnVlLCJ1cGRhdGVEaWFncmFtIjpmYWxzZX0)](https://mermaid-js.github.io/mermaid-live-editor/edit#eyJjb2RlIjoiZ3JhcGggTFJcbkEoT0JTKSAtLSBPQlMgV2Vic29ja2V0cyAtLT4gQigoT3BlblRhbGx5KSkgLS0gVVNCIC0tPiBDW09wZW5UYWxseSBVU0IgQ2xpZW50XSIsIm1lcm1haWQiOiJ7XG4gIFwidGhlbWVcIjogXCJkZWZhdWx0XCJcbn0iLCJ1cGRhdGVFZGl0b3IiOmZhbHNlLCJhdXRvU3luYyI6dHJ1ZSwidXBkYXRlRGlhZ3JhbSI6ZmFsc2V9)

3. To program Wi-Fi SSID and other information into the EEPROM of the [OpenTally Wi-Fi Client]() which communicates directly with [TallyArbiter](https://github.com/josephdadams/TallyArbiter/) once connected to network:

	[![](https://mermaid.ink/img/eyJjb2RlIjoiZ3JhcGggTFJcbkEoKE9wZW5UYWxseSkpIC0tIFVTQiAtLT4gQltPcGVuVGFsbHkgV2ktRmkgQ2xpZW50XSAtLSBVU0IgLS0-IEFcbkIgLS4gV2lGaSAuLT4gQyhUYWxseUFyYml0ZXIpLS4gV2lGaSAuLT4gQiIsIm1lcm1haWQiOnsidGhlbWUiOiJkZWZhdWx0In0sInVwZGF0ZUVkaXRvciI6ZmFsc2UsImF1dG9TeW5jIjp0cnVlLCJ1cGRhdGVEaWFncmFtIjpmYWxzZX0)](https://mermaid-js.github.io/mermaid-live-editor/edit#eyJjb2RlIjoiZ3JhcGggTFJcbkEoKE9wZW5UYWxseSkpIC0tIFVTQiAtLT4gQltPcGVuVGFsbHkgV2ktRmkgQ2xpZW50XSAtLSBVU0IgLS0-IEFcbkIgLS4gV2lGaSAuLT4gQyhUYWxseUFyYml0ZXIpLS4gV2lGaSAuLT4gQiIsIm1lcm1haWQiOiJ7XG4gIFwidGhlbWVcIjogXCJkZWZhdWx0XCJcbn0iLCJ1cGRhdGVFZGl0b3IiOmZhbHNlLCJhdXRvU3luYyI6dHJ1ZSwidXBkYXRlRGlhZ3JhbSI6ZmFsc2V9)
	
## Installation
Installation instructions can be found [here](https://www.opentally.org/installation).

## Documentation
All documentation can be found [here](https://mattv8.github.io/open-tally/).

## Contributing
I would welcome any software contributions! I have licensed the CAD parts and software as GPLv3. If you want to contribute to the software side, you will need the following:
1. Microsoft Visual Studio 2019
	- This project utilizes the [Costura.Fody](https://www.nuget.org/packages/Costura.Fody/) packager, which will have to be installed into MS Visual Studio with [NuGet](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio).

Credits
-----------------------------
- The amazing Joseph Adams and his hard work on the TallyArbiter project.
- Project ideas from the following OBS forum thread: https://obsproject.com/forum/threads/live-cameara-led.73922/.
- Arduino portion loosely based off of https://boprograms.eu/obsTally/.