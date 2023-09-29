Goal: Get as much Live Streamed Data from the PolarH10 Sensor and map it as MIDI Data to be received by a DAW or synthesizer and visualized in a browser.

Current approach:
* Copied some code for bluetooth connection from https://github.com/uwburn/cardia to have a starting point. But that will be refactored and changed as time goes on.
* Port all interesting live data from the Polar SDK from https://github.com/polarofficial/polar-ble-sdk to C#
* Use loopMidi (https://www.tobias-erichsen.de/software/loopmidi.html) as a Middle Man to send MIDI Data to the DAW 

* Use a Blazor WASM Application (https://swharden.com/blog/2021-01-07-blazor-canvas-animated-graphics/) to draw
* Use SignalR to push the data from the client Application to the WASM Application (https://stackoverflow.com/questions/11140164/signalr-console-app-example and https://learn.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-7.0)

Color Palette:
#151F23 --background, very dark
#25535D -- a little bit lighter blue
#5C662C -- dark yellow
#DDCF28 -- bright yellow
#C9C947 --brighter yellow

* Borrowed hearbeat animation from https://foolishdeveloper.com/css-heartbeat-animation/

Possible Tasks:
* Heartbeat and subsequent animation get triggered by sound
* Animate impact
* Fix Progressbar to display cumulative Hearts
* Last Level: Background color switched to brightest Yellow, face changed to sunflower
* TODO: Can i quickly get a connection working, so the sound changes too on the last level?