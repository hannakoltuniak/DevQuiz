namespace dev_quiz_api.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            DevQuizDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<DevQuizDbContext>();

            if (!context.Questions.Any())
            {
                context.AddRange
                (
                    new Question
                    {
                        QnInWords = " What is the Common Language Runtime (CLR) and what role does it play in .NET?",
                        Option1 = "CLR is the execution environment in .NET that manages running code and provides features such as garbage collection and memory management.",
                        Option2 = "CLR is a developer tool in .NET used for performance analysis of code and runtime error detection.",
                        Option3 = "CLR is an Application Programming Interface (API) in .NET enabling integration with external systems.",
                        Option4 = "CLR is a part of the .NET Framework responsible for compiling source code into Intermediate Language (IL) and executing it on the target machine",
                        Answer = 1
                    },

                    new Question
                    {
                        QnInWords = "Explain the difference between value types and reference types in C#.",
                        Option1 = "In C#, value types are objects that store a reference to their data, while reference types store the actual data directly.",
                        Option2 = "Value types in C# are immutable, meaning their values cannot be changed after creation, whereas reference types can be mutated.",
                        Option3 = "Value types in C# are always passed by reference, while reference types are passed by value.",
                        Option4 = "In C#, value types are allocated on the heap, while reference types are allocated on the stack.",
                        Answer = 2
                    },

                    new Question
                    {
                        QnInWords = "How does garbage collection work in .NET?",
                        Option1 = "Garbage collection in .NET is a manual process where developers explicitly release memory when it's no longer needed.",
                        Option2 = "Garbage collection in .NET is a process of converting unused memory into reusable memory blocks.",
                        Option3 = "Garbage collection in .NET is a background process that automatically deallocates memory that is no longer in use by any reachable object.",
                        Option4 = "Garbage collection in .NET is a process of compressing memory to reduce fragmentation and improve performance.",
                        Answer = 3
                    },

                    new Question
                    {
                        QnInWords = "Can you explain the concept of assemblies in .NET?",
                        Option1 = "Assemblies in .NET are collections of classes, resources, and metadata that form a logical unit of functionality. They can be dynamically loaded and executed by the Common Language Runtime (CLR).",
                        Option2 = "Assemblies in .NET are executable files that contain compiled code, typically in the form of DLLs or EXEs, and are used for deploying and versioning applications.",
                        Option3 = "Assemblies in .NET are data structures used for storing configuration settings and application state.",
                        Option4 = "Assemblies in .NET are files containing documentation and metadata about types, methods, and properties used in a project.",
                        Answer = 1

                    },

                    new Question
                    {
                        QnInWords = "What is the purpose of the Global Assembly Cache (GAC) in .NET?",
                        Option1 = "The GAC in .NET is a cache for storing frequently accessed data, improving application performance by reducing disk I/O operations.",
                        Option2 = "The GAC in .NET is a sandbox environment for testing and debugging assemblies before deploying them to production environments.",
                        Option3 = "The GAC in .NET is a distributed file system used for sharing assemblies across multiple servers in a network.",
                        Option4 = "The GAC in .NET is a central repository for storing shared assemblies, ensuring they are available to multiple applications on the same machine.",
                        Answer = 4
                    },

                    new Question
                    {
                        QnInWords = "Describe the differences between ASP.NET Web Forms and ASP.NET MVC.",
                        Option1 = "ASP.NET Web Forms and ASP.NET MVC are two different programming languages used for web development in the .NET framework.",
                        Option2 = "ASP.NET Web Forms is a server-side web framework that follows the Model-View-Controller (MVC) architectural pattern, while ASP.NET MVC follows a more traditional event-driven programming model.",
                        Option3 = "ASP.NET Web Forms relies on server controls and view state to manage user interface elements, whereas ASP.NET MVC allows for more control over HTML markup and client-side interactions.",
                        Option4 = "ASP.NET Web Forms is focused on rapid application development with a drag-and-drop interface, while ASP.NET MVC provides a more structured and testable approach to web development.",
                        Answer = 3
                    },

                    new Question
                    {
                        QnInWords = "What is the role of the Globalization and Localization libraries in .NET?",
                        Option1 = "Globalization and Localization libraries in .NET provide tools for optimizing code performance and reducing memory usage.",
                        Option2 = "Globalization and Localization libraries in .NET facilitate the adaptation of software to different languages, regions, and cultures, enabling the display of content in a user's preferred language and format.",
                        Option3 = "Globalization and Localization libraries in .NET are used for managing user authentication and authorization in distributed systems.",
                        Option4 = "Globalization and Localization libraries in .NET are responsible for handling network communication and data serialization in multi-tier applications.",
                        Answer = 2
                    },

                    new Question
                    {
                        QnInWords = "Explain the concept of Object-Oriented Programming (OOP) and its importance in .NET development.",
                        Option1 = "Object-Oriented Programming (OOP) is a programming paradigm that emphasizes the use of objects and classes to represent real-world entities and their interactions. In .NET development, OOP allows for code reuse, modularity, and easier maintenance.",
                        Option2 = "Object-Oriented Programming (OOP) is a design pattern commonly used in .NET development for structuring user interfaces and defining navigation flows.",
                        Option3 = "Object-Oriented Programming (OOP) is a database management technique used in .NET development for optimizing query performance and data storage.",
                        Option4 = "Object-Oriented Programming (OOP) is a security model employed in .NET development to restrict access to sensitive data and prevent unauthorized actions.",
                        Answer = 1
                    },

                    new Question
                    {
                        QnInWords = "What are the advantages of using LINQ (Language Integrated Query) in .NET development?",
                        Option1 = "LINQ in .NET provides a standardized way to query various data sources, including databases, XML, and collections, using a syntax similar to SQL, resulting in more readable and maintainable code.",
                        Option2 = "LINQ in .NET simplifies error handling and exception management by providing built-in mechanisms for handling runtime errors and failures.",
                        Option3 = "LINQ in .NET enhances security by providing encryption and decryption functions for sensitive data stored in databases or transmitted over networks.",
                        Option4 = "LINQ in .NET improves application performance by optimizing database queries and reducing network latency through caching mechanisms.",
                        Answer = 1
                    },

                    new Question
                    {
                        QnInWords = "How does exception handling work in .NET?",
                        Option1 = "In .NET, exception handling involves using try-catch blocks to handle runtime errors and exceptions. When an exception occurs, the runtime searches for a matching catch block to handle the exception. If no appropriate catch block is found, the exception is propagated up the call stack until it's caught or the program terminates.",
                        Option2 = "In .NET, exception handling relies on custom error pages to gracefully handle unexpected errors and prevent the application from crashing.",
                        Option3 = "In .NET, exception handling is handled by the operating system, which terminates the application whenever an error occurs.",
                        Option4 = "In .NET, exception handling is done using conditional statements like if-else to anticipate and prevent errors before they occur.",
                        Answer = 1
                    },

                    new Question
                    {
                        QnInWords = "What is the role of the .NET Base Class Library (BCL) in software development?",
                        Option1 = "The .NET Base Class Library (BCL) provides a set of tools for creating user interfaces and designing graphical elements in .NET applications.",
                        Option2 = "The .NET Base Class Library (BCL) is responsible for managing database connections and executing SQL queries in .NET applications.",
                        Option3 = "The .NET Base Class Library (BCL) offers a collection of reusable classes, interfaces, and value types that provide core functionality for .NET applications, such as file I/O, networking, and data types.",
                        Option4 = "The .NET Base Class Library (BCL) is used for optimizing code performance and reducing memory usage in .NET applications.",
                        Answer = 3
                    },

                    new Question 
                    {
                        QnInWords = "Can you explain the concept of multithreading in .NET and its importance?",
                        Option1 = "Multithreading in .NET allows multiple tasks to execute concurrently within the same process, enabling better CPU utilization and responsiveness in applications, particularly those that perform I/O-bound or CPU-bound operations.",
                        Option2 = "Multithreading in .NET is a technique for securing sensitive data and preventing unauthorized access to resources by allowing only one thread to access a resource at a time.",
                        Option3 = "Multithreading in .NET involves using multiple physical processors to execute tasks simultaneously, resulting in faster execution times and improved application performance.",
                        Option4 = "Multithreading in .NET is primarily used for load balancing and fault tolerance in distributed systems, ensuring that tasks are evenly distributed across multiple servers to prevent overloads and system failures.",
                        Answer = 1
                    },

                    new Question 
                    {
                        QnInWords = "Describe the features and benefits of Entity Framework in .NET development.",
                        Option1 = "Entity Framework in .NET provides a lightweight ORM (Object-Relational Mapping) framework that simplifies database access and manipulation by allowing developers to work with database objects as .NET objects, eliminating the need for manual SQL queries and data mapping.",
                        Option2 = "Entity Framework in .NET offers built-in security features such as encryption and decryption for protecting sensitive data stored in databases or transmitted over networks.",
                        Option3 = "Entity Framework in .NET enables seamless integration with cloud services such as Azure, allowing developers to deploy and scale applications with ease.",
                        Option4 = "Entity Framework in .NET automates the deployment and management of database schemas, reducing the complexity of database administration tasks and improving development productivity.",
                        Answer = 1
                    },

                    new Question
                    {
                        QnInWords = "How does .NET Core differ from the traditional .NET Framework, and why might you choose one over the other for a project?",
                        Option1 = ".NET Core is a cross-platform, open-source framework, while the traditional .NET Framework is primarily designed for Windows environments. You might choose .NET Core for projects requiring platform independence, such as developing applications for Linux or macOS, while the traditional .NET Framework might be preferred for Windows-specific applications that leverage features only available in the Windows ecosystem, such as Windows Presentation Foundation (WPF) or Windows Communication Foundation (WCF).",
                        Option2 = ".NET Core is a monolithic framework, whereas the traditional .NET Framework is modular and allows developers to include only the necessary components in their applications. You might choose .NET Core for projects requiring lightweight and scalable solutions, while the traditional .NET Framework might be preferred for applications with specific platform dependencies or legacy codebases.",
                        Option3 = ".NET Core is optimized for microservices architecture and containerization, offering better performance and scalability for cloud-native applications, while the traditional .NET Framework is more suitable for monolithic applications running on traditional infrastructure. You might choose .NET Core for projects targeting cloud environments or requiring rapid development and deployment cycles, while the traditional .NET Framework might be preferred for legacy applications or those tightly integrated with existing Windows systems.",
                        Option4 = ".NET Core has better support for modern web development frameworks and technologies such as ASP.NET Core and Blazor, while the traditional .NET Framework is limited to older technologies like ASP.NET Web Forms and Windows Communication Foundation (WCF). You might choose .NET Core for projects requiring cutting-edge web development capabilities or support for modern front-end frameworks, while the traditional .NET Framework might be preferred for maintaining legacy applications or compatibility with existing codebases.",
                        Answer = 1
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
