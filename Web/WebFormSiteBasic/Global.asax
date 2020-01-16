<%@ Application Language="C#" %>
<%@ Import Namespace="WebFormSiteBasic" %>
<%@ Import Namespace="System.Web.Optimization" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // 응용 프로그램 시작 시 실행되는 코드
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        AuthConfig.RegisterOpenAuth();
    }
    
    void Application_End(object sender, EventArgs e)
    {
        //  응용 프로그램 종료 시 실행되는 코드

    }

    void Application_Error(object sender, EventArgs e)
    {
        // 처리되지 않은 오류 발생 시 실행되는 코드

    }

</script>
