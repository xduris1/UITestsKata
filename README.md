# UITestsKata

This repository holds basic setup of Selenium tests to perform UI tests of demo eshop https://www.saucedemo.com.

## Preparation

* Fork this repository and clone your repository to be able to modify content of the repository.
* Create new branch from main branch.
* Download chrome web driver (see instructions below).
* Implement test scenario described below.
* Commit and push your changes to the remote repository.
* Create PR from your branch to main branch.

## Setup

For running Selenium tests you need to download web driver. For us, let's install [Chrome web driver](https://chromedriver.chromium.org). After download, specify path to the web driver in `SeleniumTestsExample.cs`.

## Test scenario

* Login to the store using username `standard_user` and password `secret_sauce`

* Add product `sauce labs backpack` to the cart and check if cart contains one item

* Add product `sauce labs bike light` to the cart and check if cart contains two items

* Go to cart and check its content

* Navigate to checkout

* Type first name, second name and postal code and click continue button

* Check checkout page info - delivery type, total, payment method

* Finish order

* Check if order completed is displayed

