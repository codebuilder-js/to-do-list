using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


class ToDoList {
    static void Main() {
        Console.WriteLine("Welcome to the To Do List program.");
        
        List <string> taskList = new List <string>();
        
        string option = "";
        
        while(option != "0") {
            Console.WriteLine("1 - Add a task to the list");
            Console.WriteLine("2 - Remove a task from the list");
            Console.WriteLine("3 - View the list");
            Console.WriteLine("0 - Exit");
            Console.Write("What would you like to do: ");
            
            option = Console.ReadLine();
            
            Console.WriteLine();
            
            if(option == "1") {
                Console.Write("Enter the name of the task to add to the list: ");
                
                string task = Console.ReadLine();
                
                taskList.Add(task);
                
                Console.WriteLine("Task '" + task + "' was added to the list\n");
            } else if(option == "2") {
                Console.WriteLine("-- Itens of the list --");
                for(int i = 0; i < taskList.Count; i++) {
                    Console.WriteLine(i + ": " + taskList[i]);
                }
                
                Console.Write("Enter the number of the task to remove from the list: ");
                
                int taskNumber = Convert.ToInt32(Console.ReadLine());
                
                taskList.RemoveAt(taskNumber);
                
                Console.WriteLine();
            } else if(option == "3") {
                Console.WriteLine("-- Current tasks in the list --");
                
                for(int i = 0; i < taskList.Count; i++) {
                    Console.WriteLine(" - " + taskList[i]);
                }
                
                Console.WriteLine();
            } else if(option == "0") {
                Console.WriteLine("Exiting program...");
            } else {
                Console.WriteLine("Invalid option, type again...\n");
            }
        }
    }
}
