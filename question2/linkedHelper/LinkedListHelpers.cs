using System;
using System.Collections.Generic;

namespace linkedHelper
{
    public class LinkedListHelpers<T>
    {

        static void RemoveNodesRepeatingMoreThanTwoTimes(DynamicList<T> list)
        {
            ListNode<T> node = list.Root;
            ListNode<T> previousNodeUnique = null;

            Dictionary<T, int> valueDict = new Dictionary<T, int>();
            // loop through once, and increase the counter on the Dict
            while (node != null)
            {
                // First confirm whether this keys is present in out dictionary
                if (valueDict.ContainsKey(node.Element))
                {
                    // if present confirm whether is is already appearing twice or more, then delete it
                    if (valueDict[node.Element] >= 2)
                    {
                        list.RemoveListNode(node, previousNodeUnique);

                    }
                    valueDict[node.Element] += 1;
                    previousNodeUnique = node;
                    node = node.NextNode;

                }
                else
                {
                    // add the current value/data as the key and set it to 
                    valueDict[node.Element] = 1;
                    previousNodeUnique = node;
                    node = node.NextNode;
                }

            }

        }

    }
}