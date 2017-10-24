using System;
using System.Threading;

namespace Algorithms.Threading
{
    public class threading
    {
        static ReaderWriterLockSlim rwls = new ReaderWriterLockSlim();
        static int resources = 0;
        const int numThreads = 26;
        static bool running = true;
        static Random rnd = new Random();

        static int readerTimeouts = 0;
        static int writerTimeouts = 0;
        static int reads = 0;
        static int writes = 0;

        private static Semaphore _pool;
        private static int _padding;


        public threading()
        {
        }

        static void Main(string[] args)
        {
            // Start a series of threads to randomly read from and
            // write to the shared resource.
            //Thread[] t = new Thread[numThreads];
            //for (int i = 0; i < numThreads; i++)
            //{
            //    t[i] = new Thread(new ThreadStart(ThreadProc));
            //    t[i].Name = new String(Convert.ToChar(i + 65), 1);
            //    t[i].Start();
            //    if (i > 10)
            //        Thread.Sleep(300);
            //}

            //// Tell the threads to shut down and wait until they all finish.
            //running = false;
            //for (int i = 0; i < numThreads; i++)
            //    t[i].Join();

            //// Display statistics.
            //Console.WriteLine("\n{0} reads, {1} writes, {2} reader time-outs, {3} writer time-outs.",
            //      reads, writes, readerTimeouts, writerTimeouts);
            //Console.Write("Press ENTER to exit... ");
            //Console.ReadLine();
            _pool = new Semaphore(0, 3);
            for (int i = 0; i <= 5;i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(Worker));
                t.Start(i);
            }

            Thread.Sleep(500);
            Console.WriteLine("Main thread calls Release(3).");
            _pool.Release(3);

            Console.WriteLine("Main thread exits.");

        }

        static void ThreadProc()
        {
            // Randomly select a way for the thread to read and write from the shared
            // resource.
            while (running)
            {
                double action = rnd.NextDouble();
                if (action < .8)
                    ReadFromResource(10);
               // else if (action < .81)
                  //  ReleaseRestore(50);
              //  else if (action < .90)
                   // UpgradeDowngrade(100);
                else
                    WriteToResource(100);
            }
        }

        static void ReadFromResource(int timeout)
        {
            rwls.EnterReadLock();
            try{
                Display("read resources value " + resources);
                Interlocked.Increment(ref reads);
            }
            catch(Exception ex)
            {
                Interlocked.Increment(ref readerTimeouts);
            }
            finally{
                rwls.ExitReadLock();
            }
        }

        static void WriteToResource(int timespan)
        {
            rwls.EnterWriteLock();
            try
            {
                resources = rnd.Next(500);
                Display("write resources value " + resources);
                Interlocked.Increment(ref writes);
            }
            catch(Exception ex)
            {
                Interlocked.Increment(ref writerTimeouts);
            }
            finally{
                rwls.ExitWriteLock();
            }
        }

        //#region MyRegion
        //static void UpgradeDowngrade(int timespan)
        //{

        //    try
        //    {
        //        rwls.EnterReadLock();
        //        try
        //        {
        //            Display("read resources value " + resources);
        //            Interlocked.Increment(ref reads);
        //            try
        //            {
        //                LockCookie lc = rwls.EnterUpgradeableReadLock();
        //                try
        //                {
        //                    resources = rnd.Next(500);
        //                    Display("write resources value " + resources);
        //                    Interlocked.Increment(ref reads);
        //                }
        //                finally
        //                {
        //                    rwls.ExitUpgradeableReadLock();
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Interlocked.Increment(ref readerTimeouts);
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        ////Release all locks and later restores the lock state.
        //// Uses sequence numbers to determine whether another thread has
        //// obtained a writer lock since this thread last accessed the resource.
        //static void ReleaseRestore(int timeOut)
        //{
        //    int lastWriter;

        //    try
        //    {
        //        rwls.EnterReadLock();
        //        try
        //        {
        //            // It's safe for this thread to read from the shared resource,
        //            // so read and cache the resource value.
        //            int resourceValue = resources;     // Cache the resource value.
        //            Display("reads resource value " + resourceValue);
        //            Interlocked.Increment(ref reads);

        //            // Save the current writer sequence number.
        //            lastWriter = rwls.CurrentReadCount;

        //            // Release the lock and save a cookie so the lock can be restored later.
        //            LockCookie lc = rwls.ExitReadLock();

        //            // Wait for a random interval and then restore the previous state of the lock.
        //            Thread.Sleep(rnd.Next(250));
        //            rwls.RestoreLock(ref lc);

        //            // Check whether other threads obtained the writer lock in the interval.
        //            // If not, then the cached value of the resource is still valid.
        //            if (rwls.IsWriteLockHeld(lastWriter))
        //            {
        //                resourceValue = resources;
        //                Interlocked.Increment(ref reads);
        //                Display("resource has changed " + resourceValue);
        //            }
        //            else
        //            {
        //                Display("resource has not changed " + resourceValue);
        //            }
        //        }
        //        finally
        //        {
        //            // Ensure that the lock is released.
        //            rwls.ExitReadLock();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // The reader lock request timed out.
        //        Interlocked.Increment(ref readerTimeouts);
        //    }
        //}
       // #endregion


        static void Display(string msg)
        {
            Console.Write("Thread {0}{1}.       \r", Thread.CurrentThread.Name, msg);
        }

        private static void Worker(object num)
        {
            Console.Write("Thread {0} begins and waiting for the semaphore." + num);
            _pool.WaitOne();
            int padding = Interlocked.Add(ref _padding, 100);
            Console.Write("Thread {0} are now entered the semaphore.", num);
            Thread.Sleep(1000 + padding);
            Console.WriteLine("Thread {0} releases the semaphore.", num);
            Console.WriteLine("Thread {0} previous semaphore count: {1}",
                num, _pool.Release());
        }
    }
}
