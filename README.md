
# Welcome to Open Tally!
OpenTally works with TallyArbiter!
![OpenTally Icon](https://git.visnovsky.us/Matt/open-tally/-/raw/master/icons/Icon-02.png) + ![TallyArbiter Icon](https://github.com/josephdadams/TallyArbiter/blob/master/UI/src/assets/icons/icon-96x96.png?raw=true)

OpenTally is an open-source Windows .NET framework app with three primary purposes: 

 1. To bring functionality between Joseph Adam's [TallyArbiter](https://github.com/josephdadams/TallyArbiter/) app with which tally bus data can be sent via USB to the [OpenTally USB Client]():
	graph LR
	A(TallyArbiter) -- SocketIO --> B((OpenTally)) -- USB --> C[OpenTally USB Client]
2. To communicate directly with OBS Websockets for tally bus information which can be sent over USB to the [OpenTally USB Client]():
	graph LR
	A(OBS) -- OBS Websockets --> B((OpenTally)) -- USB --> C[OpenTally USB Client]
3. To program Wi-Fi SSID and other information into the EEPROM of the [OpenTally Wi-Fi Client]() which communicates directly with [TallyArbiter](https://github.com/josephdadams/TallyArbiter/) once connected to network:
	graph LR
	A((OpenTally)) -- USB --> B[OpenTally Wi-Fi Client] -- USB --> A
	B -. WiFi .-> C(TallyArbiter)-. WiFi .-> B
## Installation
Installation instructions can be found [here](https://www.opentally.org/installation).

## Documentation
All documentation can be found [here](https://mattv8.github.io/open-tally/).

## Contributing
Contributions are always welcome. Here's a quick guide on how to setup your local development environment:
1. Make any code changes desired
2. Submit your work as a pull request
