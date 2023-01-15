# Orchard Core Commerce

[![Join the chat at https://gitter.im/OrchardCore-Commerce/Lobby](https://badges.gitter.im/OrchardCore-Commerce/Lobby.svg)](https://gitter.im/OrchardCore-Commerce/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Documentation](https://readthedocs.org/projects/orchardcorecommerce/badge/)](https://commerce.orchardcore.net/) [![OrchardCore.Commerce NuGet](https://img.shields.io/nuget/v/OrchardCore.Commerce?label=OrchardCore.Commerce)](https://www.nuget.org/packages/OrchardCore.Commerce/) [![Cloudsmith](https://api-prd.cloudsmith.io/badges/version/orchardcore/commerce/nuget/OrchardCore.Commerce/latest/x/?render=true&badge_token=gAAAAABey9hKFD_C-ZIpLvayS3HDsIjIorQluDs53KjIdlxoDz6Ntt1TzvMNJp7a_UWvQbsfN5nS7_0IbxCyqHZsjhmZP6cBkKforo-NqwrH5-E6QCrJ3D8%3D)](https://cloudsmith.io/~orchardcore/repos/commerce/packages/detail/nuget/OrchardCore.Commerce/latest/)

The commerce module for [Orchard Core](https://github.com/OrchardCMS/OrchardCore).

It's also available on all sites of [DotNest, the Orchard SaaS](https://dotnest.com/).

## History, status, and planning

Orchard Core Commerce will be an Orchard Core port and partial rewrite of the open source [Nwazet Commerce](https://github.com/bleroy/Nwazet.Commerce) module that was built for Orchard CMS 1.x. Nwazet Commerce was initially built in 2012 by [Bertrand Le Roy](https://github.com/bleroy), loosely based on [a commerce sample](http://www.ideliverable.com/blog/writing-an-orchard-webshop-module-from-scratch-part-1) by [Sipke Schoorstra](https://github.com/sfmskywalker). The initial goal of Nwazet Commerce was to power the web site of the hardware startup Nwazet. While Nwazet is no longer operating, the Nwazet Commerce project went on, and was further developed by a group of passionate contributors who are using the platform for their own, and their customer's web sites.

Like Orchard, Nwazet Commerce was built with extensibility in mind, and as such it has its own extensions (typical examples include local tax and shipping modules). It's also pure, idiomatic Orchard.

Orchard Core represents a major evolution of the Orchard design principles, and is sufficiently different that running Nwazet Commerce on it will necessitate significant work. As such, we've decided that starting from a blank slate was the best way to go, so we'll port Nwazet Commerce piece by piece, being careful to accurately apply Orchard Core's new design principles. We also decided to adopt a new name, that gets rid of the now obsolete origins, and establishes our ambition for the module to become the go-to commerce module for Orchard Core.

This work is in its initial design phases. There's a lot of work to do, and yes, we do welcome participation in any shape or form.

The work will focus at first on porting a [minimum viable feature set](https://github.com/OrchardCMS/OrchardCore.Commerce/milestone/1).

### Done

- Product, price, and inventory parts and/or fields (those were a single part in Nwazet)
  - Note: not all products have a price
- Shopping cart
- Base infrastructure for payment, plus one implementation (Stripe)

### To do

- Checkout (probably redesigned around Orchard Workflows)
- Order content type and management screens (including a redesign and refactoring of the order part)
- Workflow activities

Globalization should be taken into account at every step.

## Setting up your dev environment

### Pre-requisites

This project uses `Lombiq Node.js Extensions` to compile and lint client-side assets. See its pre-requisites [here](https://github.com/Lombiq/NodeJs-Extensions/tree/dev#pre-requisites).

### Setup

1. Clone this repository.
2. Build and run the `OrchardCore.Commerce.Web` project.
3. Run the `OrchardCore Commerce - Development` recipe on the setup screen.
4. Go to _Features_, search for "Commerce" and turn on everything.
5. Go to _Settings_ → _Stripe API_. Set the keys (test keys can be found below). If the keys are not set, payment won't work.
6. Go to Content Items, and create a `Product`.

## Test data for Stripe Payment

### API keys

Stripe API uses a secret-publishable key pair. The following API keys are public sample test keys, they can be found in [Stripe's documentation](https://stripe.com/docs/keys#obtain-api-keys).

- Publishable key: `pk_test_51H59owJmQoVhz82aWAoi9M5s8PC6sSAqFI7KfAD2NRKun5riDIOM0dvu2caM25a5f5JbYLMc5Umxw8Dl7dBIDNwM00yVbSX8uS`
- Secret key: `sk_test_51H59owJmQoVhz82aOUNOuCVbK0u1zjyRFKkFp9EfrqzWaUWqQni3oSxljsdTIu2YZ9XvlbeGjZRU7B7ye2EjJQE000Dm2DtMWD`
- Webhook signing key: Uniquely generated by the Stripe CLI as described below, it looks like `whsec_453d1046fc31377b7a93...`

**Publishable and secret keys are just publicly available test keys. Don't submit any personally identifiable information in requests made with this key.**

You can obtain your own test keys from the Stripe dashboard. You can find them at _Dashboard → Developers → API keys_.

### Webhook signing key

It is not needed, but recommended to use webhook. Otherwise, if there is a problem with redirecting the user, the payment confirmation will fail.

There is no publicly available webhook signing key. Use your own API keys and Webhook key. Create your own at _Dashboard → Developers → Webhooks_.

Read about webhook status codes [here](https://stripe.com/docs/webhooks/best-practices#pending-webhook-statuses). Our webhook endpoint returns _200_ if the request was received without an exception. It does not mean that it has been processed. It returns _400_ if there was an exception inside the webhook controller. Everything else comes from Stripe itself.

#### Webhook local testing

1. Use/Install [Stripe CLI](https://stripe.com/docs/stripe-cli).
2. Login to your stripe account: `stripe login`
3. Set the endpoint for listening e.g: `stripe listen --forward-to https://localhost:5001/stripe-webhook`
4. Copy and save the webhook key on the _/Admin/Settings/StripeApi_ page.
5. Test the payment.

### Cards

There are available test cards that can be found in [Stripe's documentation](https://stripe.com/docs/testing).

There are multiple test cards that can simulate any scenario, including error codes. Here are two examples:

| Brand |      Number      |      CVC     |       Date      |                  Result                  |
| ----- | ---------------- | ------------ | --------------- | ---------------------------------------- |
| Visa  | 4242424242424242 | Any 3 digits | Any future date | success                                  |
| Visa  | 4000000000009995 | Any 3 digits | Any future date | card_declined, insufficient_funds        |
| Visa  | 4000000000003220 | Any 3 digits | Any future date | success, goes through 3DS authentication |

[Demo video](https://youtu.be/bIXwss2NpKs) about Stripe Payment integration.

## Demo video

[![Watch the video](https://img.youtube.com/vi/EVvwS1UaIk4/maxresdefault.jpg)](https://youtu.be/EVvwS1UaIk4)
