/*
SQLyog Community v13.0.0 (64 bit)
MySQL - 5.5.60 : Database - auto_notifier
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`auto_notifier` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `auto_notifier`;

/*Table structure for table `contacts` */

DROP TABLE IF EXISTS `contacts`;

CREATE TABLE `contacts` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `type` varchar(10) DEFAULT NULL,
  `value` varchar(100) DEFAULT NULL,
  `rule_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_rule_id` (`rule_id`),
  CONSTRAINT `fk_rule_id` FOREIGN KEY (`rule_id`) REFERENCES `rule_base` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=95 DEFAULT CHARSET=latin1;

/*Data for the table `contacts` */

insert  into `contacts`(`id`,`type`,`value`,`rule_id`) values 
(80,'MOBILE','9723335284',3),
(81,'EMAIL','gcchavda@gmail.com',3),
(82,'MOBILE','919723335284',4),
(83,'EMAIL','gcchavda@live.com',4),
(84,'EMAIL','gcchavda@gmail.com',4),
(89,'MOBILE','919723335284',5),
(90,'EMAIL','gcchavda@gmail.com',5),
(91,'MOBILE','919497832376',6),
(92,'MOBILE','919723335284',6),
(93,'EMAIL','rkpsree@gmail.com',6),
(94,'EMAIL','gcchavda@gmail.com',6);

/*Table structure for table `db_connection` */

DROP TABLE IF EXISTS `db_connection`;

CREATE TABLE `db_connection` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hostname` varchar(255) DEFAULT NULL,
  `port` int(11) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `dbname` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `db_connection` */

insert  into `db_connection`(`id`,`hostname`,`port`,`username`,`password`,`dbname`) values 
(1,'localhost',3306,'root','root','ganesha');

/*Table structure for table `general_settings` */

DROP TABLE IF EXISTS `general_settings`;

CREATE TABLE `general_settings` (
  `id` int(11) NOT NULL,
  `adminemail` varchar(255) DEFAULT NULL,
  `adminmobile` varchar(12) DEFAULT NULL,
  `statustime` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `general_settings` */

insert  into `general_settings`(`id`,`adminemail`,`adminmobile`,`statustime`) values 
(1,'gcchavda@gmail.com','919723335284','14:28');

/*Table structure for table `rule_base` */

DROP TABLE IF EXISTS `rule_base`;

CREATE TABLE `rule_base` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ruleName` varchar(255) DEFAULT NULL,
  `tableName` varchar(255) DEFAULT NULL,
  `timeInterval` int(10) unsigned DEFAULT NULL,
  `isActive` tinyint(1) DEFAULT NULL,
  `lastProcessedId` double DEFAULT '-1',
  `statustime` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `rule_base` */

insert  into `rule_base`(`id`,`ruleName`,`tableName`,`timeInterval`,`isActive`,`lastProcessedId`,`statustime`) values 
(3,'sample rule','tblstage',30,0,21458,23),
(4,'other sample rule       ','tblstage',20,0,21468,23),
(5,'new rule','tblstage',30,0,21469,10),
(6,'Rahul','tblstage',30,1,21469,10);

/*Table structure for table `rule_details` */

DROP TABLE IF EXISTS `rule_details`;

CREATE TABLE `rule_details` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rule_id` int(11) DEFAULT NULL,
  `columnName` varchar(255) DEFAULT NULL,
  `criteria` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_ruleid` (`rule_id`),
  CONSTRAINT `fk_ruleid` FOREIGN KEY (`rule_id`) REFERENCES `rule_base` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=latin1;

/*Data for the table `rule_details` */

insert  into `rule_details`(`id`,`rule_id`,`columnName`,`criteria`) values 
(63,3,'Temp1','<= -5 OR > 5'),
(64,3,'Temp3','< 7 OR >= 12'),
(65,3,'Temp5','=abc'),
(66,4,'Temp12','> 55'),
(70,5,'Temp1','>55'),
(71,5,'Temp2','>35'),
(72,6,'Temp2','>15'),
(73,6,'Temp3','<-22');

/*Table structure for table `sms_settings` */

DROP TABLE IF EXISTS `sms_settings`;

CREATE TABLE `sms_settings` (
  `id` int(11) NOT NULL,
  `url` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `sendername` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `sms_settings` */

insert  into `sms_settings`(`id`,`url`,`username`,`password`,`sendername`) values 
(1,'https://api.textlocal.in/send/','temp','1I7PIVzn8hk-BaCg6wRFz6yKdF6RdTbvGjtFqKjaXU','NTFIRA');

/*Table structure for table `smtp_settings` */

DROP TABLE IF EXISTS `smtp_settings`;

CREATE TABLE `smtp_settings` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hostname` varchar(255) DEFAULT NULL,
  `port` int(11) DEFAULT NULL,
  `from_email` varchar(255) DEFAULT NULL,
  `from_name` varchar(255) DEFAULT NULL,
  `from_pwd` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `smtp_settings` */

insert  into `smtp_settings`(`id`,`hostname`,`port`,`from_email`,`from_name`,`from_pwd`) values 
(1,'smtp.gmail.com',587,'autonotifier.alarm@gmail.com','Notification Alert [Auto Notifier]','ASDFG123$%');

/*Table structure for table `text_templates` */

DROP TABLE IF EXISTS `text_templates`;

CREATE TABLE `text_templates` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rule_id` int(11) DEFAULT NULL,
  `regular_sms` varchar(1000) DEFAULT NULL,
  `routine_sms` varchar(1000) DEFAULT NULL,
  `email_subject` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_rule_id3` (`rule_id`),
  CONSTRAINT `fk_rule_id3` FOREIGN KEY (`rule_id`) REFERENCES `rule_base` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

/*Data for the table `text_templates` */

insert  into `text_templates`(`id`,`rule_id`,`regular_sms`,`routine_sms`,`email_subject`) values 
(2,3,'test','tes','ttt'),
(3,4,'test','test','test'),
(6,5,'Mega Plant\r\nfound @PresentValue@ for @ColumnName@\r\nwhere limit is @Criteria@, recNo @RecNo@','This is warning','This should be my email subject'),
(7,6,'Mega Plant\r\nHere we found @PresentValue@ temperature  for @ColumnName@\r\nwhere limit is @Criteria@','Custom routine sms heading','Custom email subject');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
