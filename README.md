# TwiML Message Response API App
[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

## Deploying ##
Click the "Deploy to Azure" button above.  You can create new resources or reference existing ones (resource group, gateway, service plan, etc.)  **Site Name and Gateway must be unique URL hostnames.**  The deployment script will deploy the following:

 * Resource Group (optional)
 * Service Plan (if you don't reference exisiting one)
 * Gateway (if you don't reference existing one)
 * API App (TwiMLMessageResponse)
 * API App Host (this is the site behind the api app that this github code deploys to)

## API Documentation ##
The app has one action that generates TwiML for a message to be sent as an SMS response. It only supports sending a single message at this time. See also the [official Twilio documentation](http://www.twilio.com/docs/api/twiml/sms/message) to fully understand the effect of the inputs.

### Generate TwiML Message Action ###
The action has the following inputs

| Property | Friendly Name | Description |
| ----- | ----- | ----- |
| Text | SMS Message Text | Text of the SMS message to send |
| To | To | Number to which the message will be sent ([E.164](http://en.wikipedia.org/wiki/E.164) format) |
| From | From | Twilio number from which the message will be sent |
| Action | Action | Twilio will make a GET or POST request to this URL with the form parameters 'MessageStatus' and 'MessageSid'. |
| Method | Method | Should be either 'GET' or 'POST'. This tells Twilio whether to request the 'action' URL via HTTP GET or POST |
| StatusCallbackUrl | Status Callback URL | The 'statusCallback' attribute takes a URL as an argument. When the message is actually sent, or if sending fails, Twilio will make an asynchronous POST request to this URL. |

The action will return the following output provided valid data

| Property | Friendly Name | Description |
| ----- | ----- | ----- |
| TwiMLMessage | TwiML Message | TwiML output wrapping the input text |

