using System;
using Azure.Storage.Queues.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsDotNet7Example
{
    public class QueueTriggerFunctionExample
    {
        private readonly ILogger<QueueTriggerFunctionExample> _logger;

        public QueueTriggerFunctionExample(ILogger<QueueTriggerFunctionExample> logger)
        {
            _logger = logger;
        }

        [Function(nameof(QueueTriggerFunctionExample))]
        public void Run([QueueTrigger("myqueue-items", Connection = "connection-string-goes-here")] QueueMessage message)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {message.MessageText}");
        }
    }
}

