using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSet : MonoBehaviour
{
    //스테이지 2차원 배열을 만든다
    static public string[][] stage = new string[][]
    {

        new string[]
        {
            "  .*..*.  ",
            "  .****.   ",
            "  ******    ,",
            "  .****.   ",
            "  .*..*.  "

        },

        new string[]
        {
            "  .*...*.  ",
            "  >**..**.  ",
            "  ***.***   ",
            "  >**..**   ",
            "  .*...*.  "
        },

        new string[]
        {
            "  **....**  ",
            "  **.**.**   ",
            "^ ..*..*..  ",
            "^ **.**.**   ",
            "  **....**  "
        },

        new string[]
        {
            "  ...**...  ",
            "^ ..*..*..   ",
            "^ .*.**.*.    ",
            "^ ..*..*..   ",
            "^ **.**.**    ",
            "^ ..*..*..   ",
            "^ .*.**.*.    ",
            "^ ..*..*..   ",
            " ...**...  "
        },

        new string[]
        {
            "  .*.>*.>*   ",
            "  **.**.**   ",
            "^ ..*..*..  ",
            "^ **.**.**    ",
            "^ ..*..*..  ",
            "^ .*.**.*.   ",
            " .*.>*.>*    "
        },

        new string[]
        {
            "  .**...**.  ",
            "  >***..***.  ",
            "  ****.****   ",
            "  >***..***.  ",
            "  .**...**.  "
        }
    };
}
