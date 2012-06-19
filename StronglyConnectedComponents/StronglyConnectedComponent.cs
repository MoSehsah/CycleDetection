﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StronglyConnectedComponents
{
    public class StronglyConnectedComponent<T> : IEnumerable<Vertex<T>>
    {
        private LinkedList<Vertex<T>> list;

        public StronglyConnectedComponent()
        {
            this.list = new LinkedList<Vertex<T>>();
        }

        public StronglyConnectedComponent(IEnumerable<Vertex<T>> collection)
        {
            this.list = new LinkedList<Vertex<T>>(collection);
        }

        public void Add(Vertex<T> vertex)
        {
            this.list.AddLast(vertex);
        }

        public IEnumerator<Vertex<T>> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        public bool IsCycle { get { return list.Count > 1; } }
    }
}
