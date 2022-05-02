Sample ASP.NET Core API project that's going to be:
- containerized,
- publish to Azure Container Registry,
- run from image in Azure.

The idea of this project is to play with Docker, ACR, Kubernetes technologies.

Useful links:
- https://docs.microsoft.com/en-us/azure/container-instances/container-instances-github-action

## The faced issues
Below the list of issues / problem I've faced so far.

### The subscription is not registered to use namespace 'Microsoft.ContainerInstance'
During deployment of application from GitHub Action I got an error:

```
Error: Error: The subscription is not registered to use namespace 'Microsoft.ContainerInstance'. See https://aka.ms/rps-not-found for how to register subscriptions.
```

Simple fix is to add required namespace to the subscription. It can be done from Azure Web Portal:
https://medium.com/@woeterman_94/how-to-solve-the-subscription-is-not-registered-to-use-namespace-in-azure-36bd2dfde3b0