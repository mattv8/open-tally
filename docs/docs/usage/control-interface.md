---
sidebar_position: 1
---

# Control Interface
TallyArbiter runs an HTTP server listening on port `4455`. If this port is in use and cannot be opened, you will receive an error.
To get to the web interface, open your browser to <http://127.0.0.1:4455> if you're on the same machine where you're running the software. If now, just replace `127.0.0.1` with the IP of that machine.

If you're running the Desktop App, you get a window showing the GUI. However, the web interface is also available at the url described above.

## Configuration
In the configuration interface, the settings page is available at `/settings`: <http://127.0.0.1:4455/settings>
**This page is restricted by a username and password. The default username is `admin` and the default password is `12345`.**

All the changes you make there are saved to a `config.json` file. This file should also be backed up frequently to prevent data loss when updating. It's path is different depending on the OS that you're running:

* Windows: `C:\Users\YourUsername\AppData\Roaming\TallyArbiter\config.json`
* MacOS: `~/Library/Preferences/TallyArbiter/config.json`
* Linux: `~/.local/share/TallyArbiter/config.json`

You can also manually edit that file.

**Make sure that TallyArbiter is closed while making changes, because otherwise they will be overwritten!**

You can change the security of the settings and the producer page by adding or replacing the following section to your `config.json` file:
```javascript
{
	"security":
	{
		"username_settings": "admin",
		"password_settings": "12345",
		"username_producer": "producer",
		"password_producer": "12345"
	}
}
```