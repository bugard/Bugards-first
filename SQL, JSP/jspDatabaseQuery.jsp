<html>
<body bgcolor ="peachpuff">
<%@ page import = "java.sql.*" %>

<h1>Query Records linksupply Database</h1>

<%
Connection conn = null;
Statement stmt=null;

try{
    Class.forName("com.mysql.jdbc.Driver").newInstance();
    out.print("Driver loaded");
}
catch (Exception e) {
    out.print("Driver not loaded" + e);
}

try {
    conn = DriverManager.getConnection("jdbc:mysql:" +
        "//localhost:3306/linksupply","root","abc123");
    out.print("Connection object created <br />");
    stmt = conn.createStatement();
    String queryString = "SELECT * FROM customers";
    ResultSet rs = stmt.executeQuery(queryString);
        
    String name = rs.getString("name");
    String phone = rs.getString("phone");
    float spent = rs.getString("spent");
    
    out.print(queryString);
    int value = stmt.executeUpdate(queryString);
    if (value == 1) {
        out.print("<h3>Record updated</h3>");
    }
    else {
        out.print("<h3>Record not updated</h3>");
    }
    out.print(name + " " + phone + " " + spent);
   
    
    

}
catch (Exception e) {
    out.print("Database connection problem " + e);
}
stmt.close();
conn.close();
%>
</body>
</html>