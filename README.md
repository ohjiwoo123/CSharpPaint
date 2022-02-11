# CSharpPaint
그림판(Collection+Save+Load) 완료

C++로도 그림판을 만들어 봤지만, 역시 처음부터 다시 짜는 건 쉽지 않았다.  
단순히 직선 그리는 것에도 좀 헤맸다.  
m_bDrag 의 유무가 상당히 중요하다.  

일단 직선만 완성되면 나머지는 척척 진행 되는데,  
이번 Ellipse와 Rectangle 함수는 C++과 다르게 도형을 그려서  
x,y좌표의 값에 따라서 전부 다르게 인자 값을 넣어줘야 했다.  
```
if (ar[i].endPoint.X > ar[i].startPoint.X)
{
    if (ar[i].endPoint.Y > ar[i].startPoint.Y)
    {
        e.Graphics.DrawEllipse(pen, ar[i].startPoint.X, ar[i].startPoint.Y, w, h);
        e.Graphics.FillEllipse(brush, ar[i].startPoint.X, ar[i].startPoint.Y, w, h);
    }
    else
    {
        e.Graphics.DrawEllipse(pen, ar[i].startPoint.X, ar[i].endPoint.Y, w, h);
        e.Graphics.FillEllipse(brush, ar[i].startPoint.X, ar[i].endPoint.Y, w, h);
    }
}
else
{
    if (ar[i].endPoint.Y > ar[i].startPoint.Y)
    {
        e.Graphics.DrawEllipse(pen, ar[i].endPoint.X, ar[i].startPoint.Y, w, h);
        e.Graphics.FillEllipse(brush, ar[i].endPoint.X, ar[i].startPoint.Y, w, h);
    }
    else
    {
        e.Graphics.DrawEllipse(pen, ar[i].endPoint.X, ar[i].endPoint.Y, w, h);
        e.Graphics.FillEllipse(brush, ar[i].endPoint.X, ar[i].endPoint.Y, w, h);
    }
}
```

직접 종이에 그림을 그려가면서 비교해보니 코드를 이해하기 수월했다.  
1번 2번 인자는 왼쪽 상단점을 기준, 3번 인자는 너비, 4번 인자는 높이 이다.  

---
직선,사각형,원을 완성하고, vector template으로 데이터를 관리하는 것에서  
잠시 또 한 번 막혔다.  
```
// Point 값들 초기화 
startPoint.X = 0;
startPoint.Y = 0;
endPoint.X = 0;
endPoint.Y = 0;
// 객체에 추가한 후에 m_bFill, m_bBold, m_nShape 는 상태를 유지하고 x,y값은 초기화해서 shape class를 다시 할당 
MyShape = new Shape(startPoint, endPoint, m_bFill, m_bBold, m_nShape);
```
**그림을 다 그리고 난 후에 Point 값들을 초기화를 안해서 문제가 생겼던 것이었다.**  

마지막으로 저장,불러오기 기능은 그렇게 어렵지 않았는데,  
이번에는 Binary Reader와 Binary Writer를 활용해서 저장하고 불러오기를 완성했다.  
대부분의 파일 저장 방식과 동일하게 처음에 Count 값을 넣어주고, 읽을 때도 Count 값을 먼저 읽어 와주면 된다.  
