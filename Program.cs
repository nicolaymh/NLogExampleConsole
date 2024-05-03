using NLog;




// Initialize the logger instance used throughout the application.
var logger = LogManager.GetCurrentClassLogger();

// Log an informational message indicating the start of the application.
logger.Info("Start of the order processing application.");

try
{
    // Specify the path to the orders file. This should be present in the output directory or
    // adjusted according to where the file is located.
    var filePath = "orders.txt";

    // Create an instance of the OrderProcessor class, responsible for processing orders.
    var processor = new OrderProcessor();

    // Call the ProcessOrders method to begin processing the orders from the specified file.
    processor.ProcessOrders(filePath);
}
catch (Exception ex)
{
    // If an exception is caught during the processing of orders, log an error with the exception details.
    logger.Error(ex, "Error processing orders.");
}
finally
{
    // Log an informational message indicating that the application has finished processing.
    logger.Info("The order processing application has ended.");

    // Properly shut down the LogManager, ensuring all logs are flushed and no log data is lost.
    LogManager.Shutdown();
}
