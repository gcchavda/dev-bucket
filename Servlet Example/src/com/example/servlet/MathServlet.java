package com.example.servlet;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class MathServlet extends HttpServlet{
	@Override
	public void init() throws ServletException {
		// TODO Auto-generated method stub
		super.init();
	}
	
	@Override
	protected void service(HttpServletRequest arg0, HttpServletResponse arg1) throws ServletException, IOException {
		/*
		 *  Usually service method decides which method to be called out of doGet, doPost or doDelete
		 *  Base implementation of this method takes care of method selection based on the incoming request
		 *  Each time when it gets the request, it spawns new thread for process execution as per the settings of the servlet container.
		 *  More than 90% time this method is not required to be written by the user unless you are working with RPC implementation
		 */
		super.service(arg0, arg1);
	}
	
	@Override
	protected void doDelete(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		// TODO Auto-generated method stub
		super.doDelete(req, resp);
	}
	
	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		String operator = req.getParameter("operator");
		Integer value1 = Integer.parseInt(req.getParameter("val1"));
		Integer value2 = Integer.parseInt(req.getParameter("val2"));
		Integer result = 0;
		if(operator.equals("+"))
			result = value1 + value2;
		else if (operator.equals("-"))
			result = value1 - value2;
		resp.getWriter().print(result.toString());
			
	}
	
	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		// 
		super.doPost(req, resp);
	}
	
	@Override
	public void destroy() {
		/*
		 * This method is called when life cycle of servlet is over. This allows you to destroy database connection objects
		 * active background threads or any other cleanup which is required to be done as part of the servlet processing.
		 */
		super.destroy();
	}
}
