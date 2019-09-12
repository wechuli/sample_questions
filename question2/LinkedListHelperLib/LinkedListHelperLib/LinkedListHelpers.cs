using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListHelperLib
{
    public class LinkedListHelpers
    {

        public static void RemoveNodesRepeatingMoreThanTwoTimes(DynamicList<char> list)
        {
            ListNode<char> node = list.Root;
            ListNode<char> previousNodeUnique = null;

            Dictionary<char, int> valueDict = new Dictionary<char, int>();
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
                    else
                    {
                        valueDict[node.Element] += 1;
                        previousNodeUnique = node;
                    }
                }
                else
                {
                    // add the current value/data as the key and set it to 
                    valueDict[node.Element] = 1;
                    previousNodeUnique = node;

                }

                node = node.NextNode;

            }

        }

    }
}
