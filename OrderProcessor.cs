using System;
using System.IO;
using NLog;

/// <summary>
/// Class responsible for processing orders from a specified file.
/// </summary>
public class OrderProcessor
{
    // Logger instance for this class.
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();

    /// <summary>
    /// Processes orders by reading them from a file and logging different events.
    /// </summary>
    /// <param name="filePath">The path to the orders file.</param>
    public void ProcessOrders(string filePath)
    {
        // Log a trace message when entering the method.
        logger.Trace("Entering ProcessOrders method.");

        // Check if the file exists at the specified path.
        if (!File.Exists(filePath))
        {
            // Log an error if the file does not exist.
            logger.Error("The file does not exist: " + filePath);

            // Warn that the system will proceed with a default order list for demonstration purposes.
            logger.Warn("Proceeding with a default order list for demonstration.");

            // Process a predefined set of default orders.
            ProcessDefaultOrders();
            return;
        }

        // Read all lines from the file and log a debug message with the number of orders.
        var lines = File.ReadAllLines(filePath);
        logger.Debug($"File opened: {filePath}. Number of orders: {lines.Length}");

        // Process each line in the file.
        foreach (var line in lines)
        {
            try
            {
                // Log informational message about processing each order.
                logger.Info($"Processing order: {line}");
            }
            catch (Exception ex)
            {
                // Log a warning if there is an issue processing the order.
                logger.Warn($"Issue encountered while processing order: {line}");

                // Log an error with the exception details if an error occurs.
                logger.Error(ex, "Error processing the order.");
            }
        }

        // Log an informational message when all orders are processed.
        logger.Info("Processing of all orders completed.");

        // Log a trace message when exiting the method normally.
        logger.Trace("Exiting ProcessOrders method normally.");
    }

    /// <summary>
    /// Processes a default set of orders when no specific order file is available.
    /// </summary>
    private void ProcessDefaultOrders()
    {
        // Log debug information about processing default orders.
        logger.Debug("Processing default orders as fallback.");

        try
        {
            // Log information about a specific default order being processed.
            logger.Info("Processing default order 001.");
            // Simulate more processing here.
        }
        catch (Exception ex)
        {
            // Log an error if there is an issue processing the default orders.
            logger.Error(ex, "Error processing default orders.");
        }

        // Log a fatal error to demonstrate the fatal log level (normally used for very severe error events).
        logger.Fatal("This is a demo of a fatal log level.");
    }
}
