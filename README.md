[![Build Status](https://travis-ci.org/mniak/HttpFallback.svg?branch=master)](https://travis-ci.org/mniak/HttpFallback)
# HttpFallback
Libraries to throw fallback HTTP errors instead of 404

# Available error pages

- 400
- 401
- 403
- 404

- 500
- 501
- 502
- 503
- 520
- 521
- 533

# Usage

## Normal Asp.NET websites

Add the handler to your `Web.config` file.
```xml
<system.webServer>
  ...
  <handlers>
    ...
    <add name="Http404Handler" verb="" path="*" type="HttpFallback.AspNet.Http404Handler, HttpFallback.AspNet" />
  </handlers>
  ...
</system.webServer>
```
Check the *Available error pages* topic to know which error codes can be used


## Owin web applications
Add this to your `Startup.cs` file:
```
app.Use<HttpFallbackOwinMiddleware>(404)
```

Check the *Available error pages* topic to know which error codes can be used

## Acknowledgements
The Error pages were copied from the project [HttpErrorPages](https://github.com/AndiDittrich/HttpErrorPages)


## Donations

Did you find this project useful? Consider making a donation.

[![Donate via PayPal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=4K22SYGEXCS6Q)
