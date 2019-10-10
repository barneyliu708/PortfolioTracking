# PortfolioTracking
 This application is used to retrieve the market price and monitor the performance of portfolio
 
 
## Getting Started
 Please set the project "PortfolioTracking.Presentation" as the startup project
 
 
## Project Structure
 ![PortfolioTrackingImage](https://user-images.githubusercontent.com/23193824/66608930-b288d380-eb85-11e9-984a-cf249d5dfc92.png)
 ### PortfolioTracking.Presentation
  This is the presentation layer built with Windows Forms.
 
 ### PortfolioTracking.Web
  Not ready, in progress. Will expose the data returned by service layer and also include UI application like angular, reactJS or even WinForm.
 
 ### PortfolioTracking.Services 
  This is the service layer which holds all the business logic
  
 ### PortfolioTracking.BusinessObjects 
  This is the business object library which are returned by service layer
  
 ### PortfolioTracking.Infrascture
  This is the infrascture layer where manages the data access.
  
  
## Running the tests
 Unit tests are in Test\ folder
 
 
## Built With
* .NET Framework 4.7.2
* Windows Forms
* Autofac 4.9.2
* Entity Framework 6.3.0
* Log4Net 2.0.8
* NUnit 3.12.0
* Moq 4.13.0


## Authors
* **Nanke Liu**
