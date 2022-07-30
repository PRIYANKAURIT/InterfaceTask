using System;
using System.ComponentModel.DataAnnotations;

namespace InterfaceTask.Models
{
    public class Values
    {
        [Required]
        public int a { get; set; }

        [Required]
        public int b { get; set; }
        [Required]
        public int c { get; set; }

        public int Add;
        public int Multi;
    }
    public interface Math
    {
        public int Add(int a, int b, int c);
        public int Multi(int a, int b, int c);

    }

public class IMaths : Math
{
    public int Add(int a, int b,int c)
    {
        int ans = a + b;
        return ans;
    }

    public int Multi(int a, int b,int c)
    {
        int ans = a * b;
        return ans;
    }
}
}