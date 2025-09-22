﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lớp trừu tượng 'Subject' (Chủ thể)
/// </summary>
public abstract class Subject
{
    private List<Observer> observers = new List<Observer>();
    public void Attach(Observer observer)
    {
        observers.Add(observer);
    }
    public void Detach(Observer observer)
    {
        observers.Remove(observer);
    }
    public void Notify()
    {
        foreach (Observer o in observers)
        {
            o.Update();
        }
    }
}
