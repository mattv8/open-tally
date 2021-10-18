---
sidebar_position: 2
---

# Sources
Sources represent all of the tally data that is generated. This is usually your video switcher or mixing software. Multiple sources can be added and they can all be different types.

The following source types are supported:
* TSL 3.1/5.0 UDP/TCP (Ross switchers, Streamstar, FOR-A, etc. - any device that uses the TSL UMD protocol)
* Blackmagic ATEM
* Blackmagic VideoHub
* OBS Studio
* StudioCoast VMix
* Roland Smart Tally
* Roland VR-50HD-MKII
* Ross Carbonite/Carbonite Black/Carbonite Black Solo/Carbonite Ultra/Graphite
* Newtek Tricaster
* Open Sound Control (OSC)
* Panasonic AV-HS410
* Analog Way Livecore Image Processors

When you add a source and the connection to the tally source (video switcher, software, etc.) is successfully made, the source will be green. If there is an error, the source will be red. Look at the logs for more error information.

## TSL 3.1 UDP/TCP
Your switcher or service that uses this protocol must be configured to send the data to Tally Arbiter at the port you specify.

## Blackmagic ATEM
You will need the IP address of the ATEM. The ATEM can only have 5 simultaneous connections, so you may need to disconnect another connection in order for Tally Arbiter to connect to the ATEM.

## Blackmagic VideoHub
You will need the IP address of the VideoHub. You can choose to have any destination be configured as a preview bus, program bus, or both. Enter multiple destination routes by separating them with commas.

## OBS Studio
The `obs-websockets` plugin must be installed and configured in order for Tally Arbiter to connect. You can get the plugin here: https://github.com/Palakis/obs-websocket/releases

You will need to supply the IP address, port, and password configured in the OBS Websockets plugin.

## StudioCoast VMix
You will need the IP address of the computer running VMix.

## Roland Smart Tally
You will need the IP address of the Roland switcher.

## Roland VR-50HD-MKII
You will need the IP address of the Roland switcher.

## Ross Carbonite Models
You will need the IP address of the Ross Carbonite switcher. Your Carbonite must be configured to send the data to Tally Arbiter at the port you specify. All Ross products use the TSL 3.1/5.0 protocols, however this specific source type allows you to process tally information by specific supported busses (ME1, MME1, Auxes, etc.) regardless of the "OnAir" setting that is configured on the Carbonite itself.

## Newtek Tricaster
You will need the IP address of the Tricaster.

## Open Sound Control (OSC)
Incoming OSC data can be used to trigger device tally states. Configure the port as desired.

OSC paths must be one of the following:
* `/tally/preview_on`: Puts the device in Preview mode.
* `/tally/preview_off`: Turns off Preview mode for the device.
* `/tally/program_on`: Puts the device in Program mode.
* `/tally/program_off`: Turns off Program mode for the device.
* `/tally/previewprogram_on`: Puts the device in both Preview and Program mode.
* `/tally/previewprogram_off`: Turns off both Preview and Program Program mode for the device.

The device source address should be sent as an integer or a string. Send one argument of any type (integer, float, or string). If you send multiple arguments, they will be ignored.

## Panasonic AV-HS410
You will need the IP address of the switcher.

## Analog Way Livecore Image Processors
You will need the IP address of the device, and the port (standard port is 10600).
