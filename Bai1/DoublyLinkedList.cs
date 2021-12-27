using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Node
    {
        private Flight data;
        private Node prev;
        private Node next;
        public Node() { }
        public Node(Flight newData)
        {
            this.data = newData;
            this.prev = null;
            this.next = null;
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node Prev
        {
            get { return prev; }
            set { prev = value; }
        }
        public Flight Data
        {
            get { return data; }
            set { data = value; }
        }
       
        public bool IsEmptyNode()
        {
            if (data == null)
                return true;
            return false;
        }
    }
    public class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        public Node Head
        {
            get { return head; }
            set { head = value; }
        }
        public Node Tail
        {
            get { return tail; }
            set { tail = value; }
        }

        public DoublyLinkedList()
        {
            Tail = Head = null;
        }
        public bool isEmptyList()
        {
            if (Head == null)
                return true;
            return false;
        }

        //Thêm vào đầu danh sách
        public void addHead(Flight newData)
        {
            // kiem tra trung du lieu
            Node lnk = null;
            bool found = false;
            if (!isEmptyList())
            {
                lnk = Head;
                while (lnk != null && !found)
                {
                    if (lnk.Data.Equals(newData))
                        found = true;
                    else
                        lnk = lnk.Next;
                }
            }
            if (!found)
            {
                Node newNode = new Node(newData);
                if (isEmptyList())//linkedlist rỗng
                    Head = Tail = newNode;
                else
                {
                    newNode.Next = Head;
                    Head.Prev = newNode;
                    Head = newNode;
                }
            }
            else
            {
                Console.WriteLine("\t{0} đã có trong danh sách", lnk.Data.ToString());
            }
        }

        // Them vao sau node
        public void addAfter(Flight newData, Flight prev)
        {
            Node prev_Node= searchNode(prev);
            if (prev_Node == null)
            {
                Console.WriteLine("\tKhông tồn tại node trước Node cần thêm");
                return;
            }

            // kiem tra trung du lieu
            Node lnk = null;
            bool found = false;
            if (Head != null)
            {
                lnk = Head;
                while (lnk != null && !found)
                {
                    if (lnk.Data.Equals(newData))
                        found = true;
                    else
                        lnk = lnk.Next;
                }
            }

            // 
            if (!found)
            {
                Node newNode = new Node(newData);
                newNode.Next = prev_Node.Next;

                newNode.Prev = prev_Node;

                if (newNode.Next != null)
                    prev_Node.Next.Prev = newNode;
                else
                    Tail = newNode;
                prev_Node.Next = newNode;
            }
            else
            {
                Console.WriteLine("\t{0} đã có trong danh sách", lnk.Data.ToString());
            }
        }

        // Thêm vào cuối danh sách
        public void addTail(Flight newData)
        {
            // kiem tra trung du lieu
            Node lnk = null;
            bool found = false;
            if (!isEmptyList())
            {
                lnk = Head;
                while (lnk != null && !found)
                {
                    if (lnk.Data.Equals(newData))
                        found = true;
                    else
                        lnk = lnk.Next;
                }
            }
            if (!found)
            {
                Node newNode = new Node(newData);
                if (isEmptyList())
                    Head = Tail = newNode;
                else
                {
                    newNode.Prev = Tail;
                    Tail.Next = newNode;
                    Tail = newNode;
                }
            }
            else
            {
                Console.WriteLine("\t{0} đã có trong danh sách", lnk.Data.ToString());
            }

        }

        // Thêm vào cuối danh sách
        public void addTail(Node newData)
        {
            // kiem tra trung du lieu
            Node lnk = null;
            bool found = false;
            if (Head != null)
            {
                lnk = Head;
                while (lnk != null && !found)
                {
                    if (lnk.Data.Equals(newData))
                        found = true;
                    else
                        lnk = lnk.Next;
                }
            }
            if (!found)
            {
                Node newNode = newData;
                if (isEmptyList() == true)
                    Head = Tail = newNode;
                else
                {
                    newNode.Prev = Tail;
                    Tail.Next = newNode;
                    Tail = newNode;
                }

            }
            else
            {
                Console.WriteLine("\t{0} đã có trong danh sách", lnk.Data.ToString());
            }

        }

        // Xóa node đầu list
        public Flight removeHead()
        {
            Flight info = default(Flight);
            if (isEmptyList())
                return null;
            else
            {
                if (Head == Tail)
                {
                    info = Head.Data = Tail.Data;
                    Head = Tail = null;
                }
                else
                {
                    info = Head.Data;

                    Head = Head.Next;
                    Head.Prev = null;
                }
            }
            return info;
        }

        // Xóa node cuối list
        public Flight removeTail()
        {
            Flight info = default(Flight);
            if (isEmptyList())
                return null;
            else
            {
                if (Head == Tail)
                {
                    info = Head.Data = Tail.Data;
                    Head = Tail = null;
                }
                else
                {
                    info = Head.Data;

                    Tail.Prev.Next = null;
                    Tail = Tail.Prev;
                }
            }
            return info;
        }

        // Xóa node sau node after  (node x là node bị xóa)
        // Node after -> Node x ->....
        // =>> Sau khi xóa: Node after ->.... 
        public Flight removeAfter(Flight prev)
        {
            Node prev_Node = searchNode(prev);
            Flight info = default(Flight);
            if (Tail != prev_Node && prev_Node!=null)
            {
               
                info = prev_Node.Next.Data;

                prev_Node.Next.Prev = prev_Node;
                prev_Node.Next = prev_Node.Next.Next;
            }
            else
                return null;
            return info;
        }

        // Xoa node
        public Flight removeNode(Node p)//xóa khỏi danh sách
        {
            Flight info = default(Flight);
            // kiem tra LinkedList rong
            if (isEmptyList())
            {
                Console.WriteLine("\tDanh sách rỗng không thể xóa");
                return null;
            }
            if (p.Prev == null)
                info = removeHead();
            else if (p.Next == null)
                info = removeTail();

            else
            {
                Node next = p.Next;
                Node prev = p.Prev;
                next.Prev = prev;
                prev.Next = next;
                p.Next = null;
                p.Prev = null;
            }
            return info;
        }

        // Xóa Node theo mã chuyến bay
        public Flight removeKey(Flight key)
        {
            Flight info = default(Flight);
            // kiem tra LinkedList rong
            if (isEmptyList())
            {
                Console.WriteLine("\tDanh sách rỗng không thể xóa");
                return null;
            }
            Node p = searchNode(key);//tim kiem node can xoa

            if (p.Prev == null)
                info = removeHead();
            else if (p.Next == null)
                info = removeTail();
            else
            {
                Node next = p.Next;
                Node prev = p.Prev;
                next.Prev = prev;
                prev.Next = next;
                p.Next = null;
                p.Prev = null;
            }
            return info;
        }

        // Tìm kiếm 1 node
        public Node searchNode(Flight key)
        {
            Node temp = Head;
            while (temp != null && !(temp.Data.maChuyenBay.Equals(key.maChuyenBay)))
            {
                temp = temp.Next;
            }
            return temp;
        }

        // Tìm kiếm các node trong danh sách đáp ứng một tiêu chí cụ thể. 
        public DoublyLinkedList searchdDau(string key)
        {
            DoublyLinkedList abc = new DoublyLinkedList();
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Data.diemDau.Equals(key))
                    abc.addTail(temp.Data);
                temp = temp.Next;
            }
            return abc;
        }

        /* hiển thị từ đầu đến cuối */
        public void print()
        {
            Node temp = Head;
            //Console.Write("\n\tĐầu đến cuối: ");
            while (temp != null)
            {
                Console.Write("\n\t-> {0} ", temp.Data.ToString());
                temp = temp.Next;
            }
            Console.WriteLine("\n");
        }

        /* hiển thị từ cuối về đầu */
        public void reversePrint()
        {
            Node temp = Tail;
            Console.Write("\n\tCuối về đầu: ");
            while (temp != null)
            {
                Console.Write("\n\t-> {0} ", temp.Data.ToString());
                temp = temp.Prev;
            }
            Console.WriteLine("\n");
        }
        //
        internal void selectionSort(DoublyLinkedList myList)
        {
            DoublyLinkedList myList2 = new DoublyLinkedList();

            Node i, j, min;
            i = myList.Head;

            while (i != null)
            {
                min = i;
                for (j = i.Next; j != null; j = j.Next)
                {
                    if (min.Data.maChuyenBay.CompareTo(j.Data.maChuyenBay) > 0)//min.Data > j.Data
                        min = j;
                }
                myList2.addTail(min.Data);
                if (min == i)
                    i = i.Next;
                myList.removeKey(min.Data); // loại bỏ min ra khỏi mylist
            }
            myList.Head = myList2.Head;
            myList.Tail = myList2.Tail;
            myList = myList2;
        }
        //
        internal void quickSort(DoublyLinkedList myList)
        {
            DoublyLinkedList myList1 = new DoublyLinkedList();
            DoublyLinkedList myList2 = new DoublyLinkedList();

            Node pivot, p;

            if (myList.Head == myList.Tail)
                return;

            pivot = myList.Head;//Phần tử cầm canh 
            myList.Head = myList.Head.Next;
            pivot.Next = null;
            pivot.Prev = null;
            while (myList.Head != null)
            {
                p = myList.Head;
                myList.Head = myList.Head.Next;
                p.Next = null;
                if (p.Data.tenho.CompareTo(pivot.Data.tenho) <= 0)
                    myList1.addTail(p.Data);//Thêm vào cuối danh sách 1 
                else
                    myList2.addTail(p.Data);//Thêm vào cuối danh sách 2 
            }

            quickSort(myList1);
            quickSort(myList2);

            //Ghép nối danh sách 1 + pivot 
            if (myList1.isEmptyList() == false)//mylist1 k rỗng
            {
                myList.Head = myList1.Head;
                pivot.Prev = myList1.Tail;//
                myList1.Tail.Next = pivot;
            }
            else
            {
                pivot.Prev = null;//
                myList.Head = pivot;
            }

            //Ghép nối pivot + danh sách 2 
            Node head;

            head = myList2.Head;
            pivot.Next = head;

            if (myList2.isEmptyList() == false)
            {
                head.Prev = pivot;//
                myList.Tail = myList2.Tail;
            }
            else
                myList.Tail = pivot;
        }


        //
        public void printSapXep()
        {
            Node temp = Head;
            int count = 1;

            while (temp != null)
            {
                Console.Write("\n\t{0}.  {1}_{2}", count, temp.Data.maChuyenBay, temp.Data.tenCoTruong);
                temp = temp.Next;
                count++;
            }
            Console.WriteLine("\n");
        }
        //
        public void printTG()
        {
            Node temp = Head;
            int count = 1;

            while (temp != null)
            {
                Console.Write("\n\t{0}.  {1}_{2}", count, temp.Data.maChuyenBay, temp.Data.TGKhoiHanh);
                temp = temp.Next;
                count++;
            }
            Console.WriteLine("\n");
        }

        // Xóa các chuyến bay khởi hành trước 28/9/2021 trong danh sách
        public void removeCB()
        {
            DateTime day = new DateTime(2021, 09, 28);
            Node p = Head;
            int a = 0;
            while (p != null)
            {
                Node q = p;
                p = p.Next;
                if (q.Data.TGKhoiHanh < day)
                {
                    a++;
                    removeKey(q.Data);
                }

            }
            if (a == 0)
                Console.WriteLine("\t Không có chuyến bay nào xuất phát từ trước 28/9/2021");
        }

        // tách list từ chuyenbay x
        public DoublyLinkedList tach(DoublyLinkedList myList, Flight x)
        {
            DoublyLinkedList myList2 = new DoublyLinkedList();
            if (myList.isEmptyList() || myList.Head == myList.Tail)
                Console.WriteLine("\t Không thể tách danh sách");
            else
            {
                Node p = searchNode(x);
                if (p == myList.Head)
                {
                    Console.WriteLine("\t Danh sách tách từ {0} là danh sách ban đầu", x.maChuyenBay);
                    return myList;
                }

                myList2.Head = p;
                myList2.Tail = myList.Tail;

                myList.Tail = p.Prev;
                myList.Tail.Next = null;

            }
            return myList2;

        }
        public DoublyLinkedList hop(DoublyLinkedList myList, DoublyLinkedList myList2)
        {
            Node head;

            head = myList2.Head;
            myList.Tail.Next = head;

            if (myList2.isEmptyList() == false)
            {
                head.Prev = myList.Tail;//
                myList.Tail = myList2.Tail;
            }
            return myList;
        }
        public void editNode(Flight edit, Flight x)
        {
            Node p = searchNode(edit);
            if (p != null)
            {
                p.Data = x;
            }

        }
    }
}
