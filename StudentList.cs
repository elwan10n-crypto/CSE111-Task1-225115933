// Student Name: Mohamed Mohamed Belal Elwan
// Student ID: 225115933

namespace Cse111Task1
{
public class StudentList
{
public Student? First;
public Student? Last;
public int Count;

    public StudentList()
    {
        First = null;
        Last = null;
        Count = 0;
    }

    // Add student at the beginning
    public void AddFront(int id)
    {
        Student newStudent = new Student(id);

        if (First == null)
        {
            First = Last = newStudent;
        }
        else
        {
            newStudent.Next = First;
            First = newStudent;
        }

        Count++;
    }

    // Add student at the end
    public void AddEnd(int id)
    {
        Student newStudent = new Student(id);

        if (First == null)
        {
            First = Last = newStudent;
        }
        else
        {
            Last!.Next = newStudent;
            Last = newStudent;
        }

        Count++;
    }

    // Remove student by ID
    public bool Remove(int id)
    {
        if (First == null)
            return false;

        if (First.Id == id)
        {
            First = First.Next;
            Count--;

            if (First == null)
                Last = null;

            return true;
        }

        Student current = First;

        while (current.Next != null)
        {
            if (current.Next.Id == id)
            {
                Student removed = current.Next;
                current.Next = removed.Next;

                if (removed == Last)
                    Last = current;

                Count--;
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    // Reverse the linked list
    public void Reverse()
    {
        Student? previous = null;
        Student? current = First;

        Last = First;

        while (current != null)
        {
            Student? next = current.Next;

            current.Next = previous;
            previous = current;
            current = next;
        }

        First = previous;
    }

    // Print all students
    public void Print()
    {
        Student? current = First;

        while (current != null)
        {
            Console.Write(current.Id);

            if (current.Next != null)
                Console.Write(" ");

            current = current.Next;
        }

        Console.WriteLine();
    }
}

}
