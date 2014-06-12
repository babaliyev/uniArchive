--
-- Create Database Script 
--   Database Version          : 11.2.0.2.0 
--   Database Compatible Level : 11.2.0.0.0 
--   Toad Version              : 11.6.0.43 
--   DB Connect String         : LOCALHOST:1521/XE 
--   Script Created by         : ARCH 
--   Script Created at         : 12/06/2014 13:10:18 
--   Physical Location         :  
--   Notes                     :  
--

/* Init.ora file begins here. 

#####################################################
# Created by TOAD 
# 12/06/2014 13:10:18
# Note: Only non-default parameters are listed here. 
#####################################################

audit_file_dest = "C:\ORACLEXE\APP\ORACLE\ADMIN\XE\ADUMP" 
compatible = "11.2.0.0.0" 
control_files = (C:\ORACLEXE\APP\ORACLE\ORADATA\XE\CONTROL.DBF) 
db_name = "XE" 
db_recovery_file_dest = "C:\oraclexe\app\oracle\fast_recovery_area" 
db_recovery_file_dest_size = 10737418240 
diagnostic_dest = "C:\ORACLEXE\APP\ORACLE" 
dispatchers = "(PROTOCOL=TCP) (SERVICE=XEXDB)" 
job_queue_processes = 4 
memory_target = 1073741824 
open_cursors = 300 
remote_login_passwordfile = "EXCLUSIVE" 
sessions = 172 
shared_servers = 4 
spfile = "C:\ORACLEXE\APP\ORACLE\PRODUCT\11.2.0\SERVER\DBS\SPFILEXE.ORA" 
undo_management = "AUTO" 
undo_tablespace = "UNDOTBS1" 

Init.ora file ends here. */


CREATE TABLESPACE SYSAUX DATAFILE 
  'C:\ORACLEXE\APP\ORACLE\ORADATA\XE\UNDOTBS1.DBF' SIZE 680M AUTOEXTEND ON NEXT 10M MAXSIZE UNLIMITED
LOGGING
ONLINE
EXTENT MANAGEMENT LOCAL AUTOALLOCATE
BLOCKSIZE 8K
SEGMENT SPACE MANAGEMENT AUTO
FLASHBACK ON;


CREATE TABLESPACE SYSTEM DATAFILE 
  'C:\ORACLEXE\APP\ORACLE\ORADATA\XE\SYSTEM.DBF' SIZE 600M AUTOEXTEND ON NEXT 10M MAXSIZE 600M
LOGGING
ONLINE
EXTENT MANAGEMENT LOCAL AUTOALLOCATE
BLOCKSIZE 8K
FLASHBACK ON;


CREATE TEMPORARY TABLESPACE TEMP TEMPFILE 
  'C:\ORACLEXE\APP\ORACLE\ORADATA\XE\TEMP.DBF' SIZE 20M AUTOEXTEND ON NEXT 640K MAXSIZE UNLIMITED
TABLESPACE GROUP ''
EXTENT MANAGEMENT LOCAL UNIFORM SIZE 1M;


CREATE UNDO TABLESPACE UNDOTBS1 DATAFILE 
  'C:\ORACLEXE\APP\ORACLE\ORADATA\XE\SYSAUX.DBF' SIZE 30M AUTOEXTEND ON NEXT 5M MAXSIZE UNLIMITED
ONLINE
RETENTION NOGUARANTEE
BLOCKSIZE 8K
FLASHBACK ON;


CREATE TABLESPACE USERS DATAFILE 
  'C:\ORACLEXE\APP\ORACLE\ORADATA\XE\USERS.DBF' SIZE 100M AUTOEXTEND ON NEXT 10M MAXSIZE 11264M
LOGGING
ONLINE
EXTENT MANAGEMENT LOCAL AUTOALLOCATE
BLOCKSIZE 8K
SEGMENT SPACE MANAGEMENT AUTO
FLASHBACK ON;


ALTER DATABASE ADD LOGFILE GROUP 1(
  'C:\ORACLEXE\APP\ORACLE\FAST_RECOVERY_AREA\XE\ONLINELOG\O1_MF_1_9NO9GRJV_.LOG')
    SIZE 50M;


ALTER DATABASE ADD LOGFILE GROUP 2(
  'C:\ORACLEXE\APP\ORACLE\FAST_RECOVERY_AREA\XE\ONLINELOG\O1_MF_2_9NO9GRPL_.LOG')
    SIZE 50M;


CREATE PROFILE "DEFAULT" LIMIT
  SESSIONS_PER_USER UNLIMITED
  CPU_PER_SESSION UNLIMITED
  CPU_PER_CALL UNLIMITED
  CONNECT_TIME UNLIMITED
  IDLE_TIME UNLIMITED
  LOGICAL_READS_PER_SESSION UNLIMITED
  LOGICAL_READS_PER_CALL UNLIMITED
  COMPOSITE_LIMIT UNLIMITED
  PRIVATE_SGA UNLIMITED
  FAILED_LOGIN_ATTEMPTS 10
  PASSWORD_LIFE_TIME 180
  PASSWORD_REUSE_TIME UNLIMITED
  PASSWORD_REUSE_MAX UNLIMITED
  PASSWORD_LOCK_TIME 1
  PASSWORD_GRACE_TIME 7
  PASSWORD_VERIFY_FUNCTION NULL;


CREATE PROFILE MONITORING_PROFILE LIMIT
  SESSIONS_PER_USER DEFAULT
  CPU_PER_SESSION DEFAULT
  CPU_PER_CALL DEFAULT
  CONNECT_TIME DEFAULT
  IDLE_TIME DEFAULT
  LOGICAL_READS_PER_SESSION DEFAULT
  LOGICAL_READS_PER_CALL DEFAULT
  COMPOSITE_LIMIT DEFAULT
  PRIVATE_SGA DEFAULT
  FAILED_LOGIN_ATTEMPTS UNLIMITED
  PASSWORD_LIFE_TIME DEFAULT
  PASSWORD_REUSE_TIME DEFAULT
  PASSWORD_REUSE_MAX DEFAULT
  PASSWORD_LOCK_TIME DEFAULT
  PASSWORD_GRACE_TIME DEFAULT
  PASSWORD_VERIFY_FUNCTION DEFAULT;


CREATE ROLE ADM_PARALLEL_EXECUTE_TASK NOT IDENTIFIED;



CREATE ROLE APEX_ADMINISTRATOR_ROLE NOT IDENTIFIED;



CREATE ROLE AQ_ADMINISTRATOR_ROLE NOT IDENTIFIED;

BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_EVALUATION_CONTEXT_OBJ,
  GRANTEE      => 'AQ_ADMINISTRATOR_ROLE',
  GRANT_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_RULE_OBJ,
  GRANTEE      => 'AQ_ADMINISTRATOR_ROLE',
  GRANT_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_RULE_SET_OBJ,
  GRANTEE      => 'AQ_ADMINISTRATOR_ROLE',
  GRANT_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'DEQUEUE_ANY',
  GRANTEE      => 'AQ_ADMINISTRATOR_ROLE',
  ADMIN_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'ENQUEUE_ANY',
  GRANTEE      => 'AQ_ADMINISTRATOR_ROLE',
  ADMIN_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'MANAGE_ANY',
  GRANTEE      => 'AQ_ADMINISTRATOR_ROLE',
  ADMIN_OPTION => TRUE);
END;
/


CREATE ROLE AQ_USER_ROLE NOT IDENTIFIED;



CREATE ROLE AUTHENTICATEDUSER NOT IDENTIFIED;



CREATE ROLE CONNECT NOT IDENTIFIED;

GRANT CREATE SESSION TO CONNECT;


CREATE ROLE CTXAPP NOT IDENTIFIED;



CREATE ROLE DBFS_ROLE NOT IDENTIFIED;



CREATE ROLE DELETE_CATALOG_ROLE NOT IDENTIFIED;



CREATE ROLE GATHER_SYSTEM_STATISTICS NOT IDENTIFIED;



CREATE ROLE HS_ADMIN_EXECUTE_ROLE NOT IDENTIFIED;



CREATE ROLE HS_ADMIN_SELECT_ROLE NOT IDENTIFIED;



CREATE ROLE OEM_ADVISOR NOT IDENTIFIED;

GRANT ADMINISTER SQL TUNING SET TO OEM_ADVISOR;
GRANT ADVISOR TO OEM_ADVISOR;
GRANT CREATE JOB TO OEM_ADVISOR;


CREATE ROLE PLUSTRACE NOT IDENTIFIED;



CREATE ROLE RECOVERY_CATALOG_OWNER NOT IDENTIFIED;

GRANT ALTER SESSION TO RECOVERY_CATALOG_OWNER;
GRANT CREATE CLUSTER TO RECOVERY_CATALOG_OWNER;
GRANT CREATE DATABASE LINK TO RECOVERY_CATALOG_OWNER;
GRANT CREATE PROCEDURE TO RECOVERY_CATALOG_OWNER;
GRANT CREATE SEQUENCE TO RECOVERY_CATALOG_OWNER;
GRANT CREATE SESSION TO RECOVERY_CATALOG_OWNER;
GRANT CREATE SYNONYM TO RECOVERY_CATALOG_OWNER;
GRANT CREATE TABLE TO RECOVERY_CATALOG_OWNER;
GRANT CREATE TRIGGER TO RECOVERY_CATALOG_OWNER;
GRANT CREATE TYPE TO RECOVERY_CATALOG_OWNER;
GRANT CREATE VIEW TO RECOVERY_CATALOG_OWNER;


CREATE ROLE RESOURCE NOT IDENTIFIED;

GRANT CREATE CLUSTER TO RESOURCE;
GRANT CREATE INDEXTYPE TO RESOURCE;
GRANT CREATE OPERATOR TO RESOURCE;
GRANT CREATE PROCEDURE TO RESOURCE;
GRANT CREATE SEQUENCE TO RESOURCE;
GRANT CREATE TABLE TO RESOURCE;
GRANT CREATE TRIGGER TO RESOURCE;
GRANT CREATE TYPE TO RESOURCE;


CREATE ROLE SCHEDULER_ADMIN NOT IDENTIFIED;

GRANT CREATE ANY JOB TO SCHEDULER_ADMIN WITH ADMIN OPTION;
GRANT CREATE EXTERNAL JOB TO SCHEDULER_ADMIN WITH ADMIN OPTION;
GRANT CREATE JOB TO SCHEDULER_ADMIN WITH ADMIN OPTION;
GRANT EXECUTE ANY CLASS TO SCHEDULER_ADMIN WITH ADMIN OPTION;
GRANT EXECUTE ANY PROGRAM TO SCHEDULER_ADMIN WITH ADMIN OPTION;
GRANT MANAGE SCHEDULER TO SCHEDULER_ADMIN WITH ADMIN OPTION;


CREATE ROLE SELECT_CATALOG_ROLE NOT IDENTIFIED;

GRANT HS_ADMIN_SELECT_ROLE TO SELECT_CATALOG_ROLE;


CREATE ROLE XDBADMIN NOT IDENTIFIED;



CREATE ROLE XDB_SET_INVOKER NOT IDENTIFIED;



CREATE ROLE XDB_WEBSERVICES NOT IDENTIFIED;



CREATE ROLE XDB_WEBSERVICES_OVER_HTTP NOT IDENTIFIED;



CREATE ROLE XDB_WEBSERVICES_WITH_PUBLIC NOT IDENTIFIED;



CREATE ROLLBACK SEGMENT SYSTEM
  TABLESPACE SYSTEM
  STORAGE    (
              INITIAL          112K
              NEXT             56K
              MINEXTENTS       1
              MAXEXTENTS       32765
             );
ALTER ROLLBACK SEGMENT SYSTEM ONLINE;


CREATE OR REPLACE DIRECTORY 
DATA_PUMP_DIR AS 
'C:\oraclexe\app\oracle\admin\xe\dpdump\';


CREATE OR REPLACE DIRECTORY 
ORACLECLRDIR AS 
'C:\oraclexe\app\oracle\product\11.2.0\server\bin\clr';


CREATE OR REPLACE DIRECTORY 
ORACLE_OCM_CONFIG_DIR AS 
'C:/ADE/jaikrish_xe/oracle\ccr\state';


CREATE OR REPLACE DIRECTORY 
XMLDIR AS 
'C:\oraclexe\app\oracle\product\11.2.0\server\rdbms\xml';


begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'AUTO_TASK_CONSUMER_GROUP'
     ,comment                      => 'System maintenance task consumer group');
  sys.dbms_resource_manager.submit_pending_area();
end;
/



begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'DEFAULT_CONSUMER_GROUP'
     ,comment                      => 'Consumer group for users not assigned to any consumer group');
  sys.dbms_resource_manager.submit_pending_area();
end;
/

begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager_privs.grant_switch_consumer_group (
      grantee_name                 => 'PUBLIC'
     ,consumer_group               => 'DEFAULT_CONSUMER_GROUP'
     ,grant_option                 => TRUE);
  sys.dbms_resource_manager.submit_pending_area();
end;
/




begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'LOW_GROUP'
     ,comment                      => 'Consumer group for low-priority sessions');
  sys.dbms_resource_manager.submit_pending_area();
end;
/

begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager_privs.grant_switch_consumer_group (
      grantee_name                 => 'PUBLIC'
     ,consumer_group               => 'LOW_GROUP'
     ,grant_option                 => FALSE);
  sys.dbms_resource_manager.submit_pending_area();
end;
/




begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$APPQOS_4'
     ,comment                      => 'Consumer group for Application QOS');
  sys.dbms_resource_manager.submit_pending_area();
end;
/



begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$APPQOS_5'
     ,comment                      => 'Consumer group for Application QOS');
  sys.dbms_resource_manager.submit_pending_area();
end;
/



begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$APPQOS_6'
     ,comment                      => 'Consumer group for Application QOS');
  sys.dbms_resource_manager.submit_pending_area();
end;
/



begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$APPQOS_7'
     ,comment                      => 'Consumer group for Application QOS');
  sys.dbms_resource_manager.submit_pending_area();
end;
/



begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_plan (
      plan                         => 'APPQOS_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Plan for Application QOS Management that provides a fixed set of allocations to the consumer groups that Application QOS uses to manage workload resource allocation.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for automated maintenance tasks.  A directive to this sub-plan should be included in every top-level plan to manage the resources consumed by the automated maintenance tasks.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for high-priority, automated maintenance tasks.  This sub-plan is referenced by ORA$AUTOTASK_SUB_PLAN and should not be referenced directly.');
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,comment                      => 'Consumer group for health checks');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for health check tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SQL_GROUP'
     ,comment                      => 'Consumer group for SQL tuning');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SQL_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for SQL tuning tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SPACE_GROUP'
     ,comment                      => 'Consumer group for space management advisors');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SPACE_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for space management advisory tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_STATS_GROUP'
     ,comment                      => 'Consumer group for gathering optimizer statistics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_STATS_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for gathering optimizer statistics tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_p2                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for high-priority automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_URGENT_GROUP'
     ,comment                      => 'Consumer group for urgent maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_URGENT_GROUP'
     ,cpu_p1                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for urgent automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,comment                      => 'Consumer group for medium-priority maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,cpu_p3                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for medium-priority automated tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'APPQOS_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_p3                       => 15
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for automated maintenance tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$DIAGNOSTICS'
     ,comment                      => 'Consumer group for diagnostics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'APPQOS_PLAN'
     ,group_or_subplan             => 'ORA$DIAGNOSTICS'
     ,cpu_p3                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for automated diagnostic tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'APPQOS_PLAN'
     ,group_or_subplan             => 'OTHER_GROUPS'
     ,cpu_p3                       => 80
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for all other operations'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'APPQOS_PLAN'
     ,group_or_subplan             => 'SYS_GROUP'
     ,cpu_p1                       => 75
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for SYS_GROUP'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$APPQOS_0'
     ,comment                      => 'Consumer group for Application QOS');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'APPQOS_PLAN'
     ,group_or_subplan             => 'ORA$APPQOS_0'
     ,cpu_p2                       => 57
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for first QOS group'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$APPQOS_1'
     ,comment                      => 'Consumer group for Application QOS');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'APPQOS_PLAN'
     ,group_or_subplan             => 'ORA$APPQOS_1'
     ,cpu_p2                       => 26
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for second QOS group'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$APPQOS_2'
     ,comment                      => 'Consumer group for Application QOS');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'APPQOS_PLAN'
     ,group_or_subplan             => 'ORA$APPQOS_2'
     ,cpu_p2                       => 12
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for third QOS group'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$APPQOS_3'
     ,comment                      => 'Consumer group for Application QOS');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'APPQOS_PLAN'
     ,group_or_subplan             => 'ORA$APPQOS_3'
     ,cpu_p2                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for fourth QOS group'  );
  sys.dbms_resource_manager.submit_pending_area();
end;
/


begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_plan (
      plan                         => 'DEFAULT_MAINTENANCE_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default plan for maintenance windows that prioritizes SYS_GROUP operations and allocates the remaining 5% to diagnostic operations and 25% to automated maintenance operations.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for automated maintenance tasks.  A directive to this sub-plan should be included in every top-level plan to manage the resources consumed by the automated maintenance tasks.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for high-priority, automated maintenance tasks.  This sub-plan is referenced by ORA$AUTOTASK_SUB_PLAN and should not be referenced directly.');
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,comment                      => 'Consumer group for health checks');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for health check tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SQL_GROUP'
     ,comment                      => 'Consumer group for SQL tuning');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SQL_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for SQL tuning tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SPACE_GROUP'
     ,comment                      => 'Consumer group for space management advisors');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SPACE_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for space management advisory tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_STATS_GROUP'
     ,comment                      => 'Consumer group for gathering optimizer statistics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_STATS_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for gathering optimizer statistics tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_p2                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for high-priority automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_URGENT_GROUP'
     ,comment                      => 'Consumer group for urgent maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_URGENT_GROUP'
     ,cpu_p1                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for urgent automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,comment                      => 'Consumer group for medium-priority maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,cpu_p3                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for medium-priority automated tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DEFAULT_MAINTENANCE_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_p2                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for automated maintenance tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$DIAGNOSTICS'
     ,comment                      => 'Consumer group for diagnostics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DEFAULT_MAINTENANCE_PLAN'
     ,group_or_subplan             => 'ORA$DIAGNOSTICS'
     ,cpu_p2                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for automated diagnostic tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DEFAULT_MAINTENANCE_PLAN'
     ,group_or_subplan             => 'OTHER_GROUPS'
     ,cpu_p2                       => 70
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for all other operations'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DEFAULT_MAINTENANCE_PLAN'
     ,group_or_subplan             => 'SYS_GROUP'
     ,cpu_p1                       => 75
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for system operations'  );
  sys.dbms_resource_manager.submit_pending_area();
end;
/


begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_plan (
      plan                         => 'DEFAULT_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default, basic, pre-defined plan that prioritizes SYS_GROUP operations and allocates minimal resources for automated maintenance and diagnostics operations.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for automated maintenance tasks.  A directive to this sub-plan should be included in every top-level plan to manage the resources consumed by the automated maintenance tasks.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for high-priority, automated maintenance tasks.  This sub-plan is referenced by ORA$AUTOTASK_SUB_PLAN and should not be referenced directly.');
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,comment                      => 'Consumer group for health checks');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for health check tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SQL_GROUP'
     ,comment                      => 'Consumer group for SQL tuning');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SQL_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for SQL tuning tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SPACE_GROUP'
     ,comment                      => 'Consumer group for space management advisors');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SPACE_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for space management advisory tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_STATS_GROUP'
     ,comment                      => 'Consumer group for gathering optimizer statistics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_STATS_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for gathering optimizer statistics tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_p2                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for high-priority automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_URGENT_GROUP'
     ,comment                      => 'Consumer group for urgent maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_URGENT_GROUP'
     ,cpu_p1                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for urgent automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,comment                      => 'Consumer group for medium-priority maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,cpu_p3                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for medium-priority automated tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DEFAULT_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_p2                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for automated maintenance tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$DIAGNOSTICS'
     ,comment                      => 'Consumer group for diagnostics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DEFAULT_PLAN'
     ,group_or_subplan             => 'ORA$DIAGNOSTICS'
     ,cpu_p2                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for automated diagnostic tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DEFAULT_PLAN'
     ,group_or_subplan             => 'OTHER_GROUPS'
     ,cpu_p2                       => 90
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for all other operations'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DEFAULT_PLAN'
     ,group_or_subplan             => 'SYS_GROUP'
     ,cpu_p1                       => 75
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for system operations'  );
  sys.dbms_resource_manager.submit_pending_area();
end;
/


begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_plan (
      plan                         => 'DSS_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Example plan for DSS workloads that prioritizes DSS queries over ETL.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for automated maintenance tasks.  A directive to this sub-plan should be included in every top-level plan to manage the resources consumed by the automated maintenance tasks.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for high-priority, automated maintenance tasks.  This sub-plan is referenced by ORA$AUTOTASK_SUB_PLAN and should not be referenced directly.');
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,comment                      => 'Consumer group for health checks');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for health check tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SQL_GROUP'
     ,comment                      => 'Consumer group for SQL tuning');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SQL_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for SQL tuning tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SPACE_GROUP'
     ,comment                      => 'Consumer group for space management advisors');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SPACE_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for space management advisory tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_STATS_GROUP'
     ,comment                      => 'Consumer group for gathering optimizer statistics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_STATS_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for gathering optimizer statistics tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_p2                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for high-priority automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_URGENT_GROUP'
     ,comment                      => 'Consumer group for urgent maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_URGENT_GROUP'
     ,cpu_p1                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for urgent automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,comment                      => 'Consumer group for medium-priority maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,cpu_p3                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for medium-priority automated tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DSS_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_p2                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for Oracle automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'DSS_GROUP'
     ,comment                      => 'Consumer group for DSS queries');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DSS_PLAN'
     ,group_or_subplan             => 'DSS_GROUP'
     ,cpu_p3                       => 75
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for DSS_GROUP'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'DSS_CRITICAL_GROUP'
     ,comment                      => 'Consumer group for critical DSS queries');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DSS_PLAN'
     ,group_or_subplan             => 'DSS_CRITICAL_GROUP'
     ,cpu_p2                       => 75
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for DSS_CRITICAL_GROUP'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'BATCH_GROUP'
     ,comment                      => 'Consumer group for batch operations');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DSS_PLAN'
     ,group_or_subplan             => 'BATCH_GROUP'
     ,cpu_p4                       => 45
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for BATCH_GROUP'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$DIAGNOSTICS'
     ,comment                      => 'Consumer group for diagnostics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DSS_PLAN'
     ,group_or_subplan             => 'ORA$DIAGNOSTICS'
     ,cpu_p2                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for Oracle diagnostics'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DSS_PLAN'
     ,group_or_subplan             => 'OTHER_GROUPS'
     ,cpu_p4                       => 10
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for unclassified activity'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DSS_PLAN'
     ,group_or_subplan             => 'SYS_GROUP'
     ,cpu_p1                       => 75
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for SYS_GROUP'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ETL_GROUP'
     ,comment                      => 'Consumer group for ETL');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'DSS_PLAN'
     ,group_or_subplan             => 'ETL_GROUP'
     ,cpu_p4                       => 45
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for ETL_GROUP'  );
  sys.dbms_resource_manager.submit_pending_area();
end;
/


begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ETL_CRITICAL_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Example plan for DSS workloads that prioritizes ETL and critical DSS queries.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for automated maintenance tasks.  A directive to this sub-plan should be included in every top-level plan to manage the resources consumed by the automated maintenance tasks.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for high-priority, automated maintenance tasks.  This sub-plan is referenced by ORA$AUTOTASK_SUB_PLAN and should not be referenced directly.');
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,comment                      => 'Consumer group for health checks');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for health check tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SQL_GROUP'
     ,comment                      => 'Consumer group for SQL tuning');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SQL_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for SQL tuning tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SPACE_GROUP'
     ,comment                      => 'Consumer group for space management advisors');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SPACE_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for space management advisory tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_STATS_GROUP'
     ,comment                      => 'Consumer group for gathering optimizer statistics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_STATS_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for gathering optimizer statistics tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_p2                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for high-priority automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_URGENT_GROUP'
     ,comment                      => 'Consumer group for urgent maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_URGENT_GROUP'
     ,cpu_p1                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for urgent automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,comment                      => 'Consumer group for medium-priority maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,cpu_p3                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for medium-priority automated tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ETL_CRITICAL_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_p2                       => 3
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for Oracle automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'DSS_GROUP'
     ,comment                      => 'Consumer group for DSS queries');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ETL_CRITICAL_PLAN'
     ,group_or_subplan             => 'DSS_GROUP'
     ,cpu_p2                       => 10
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for DSS_GROUP'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'DSS_CRITICAL_GROUP'
     ,comment                      => 'Consumer group for critical DSS queries');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ETL_CRITICAL_PLAN'
     ,group_or_subplan             => 'DSS_CRITICAL_GROUP'
     ,cpu_p2                       => 35
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for DSS_CRITICAL_GROUP'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'BATCH_GROUP'
     ,comment                      => 'Consumer group for batch operations');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ETL_CRITICAL_PLAN'
     ,group_or_subplan             => 'BATCH_GROUP'
     ,cpu_p2                       => 10
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for BATCH_GROUP'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$DIAGNOSTICS'
     ,comment                      => 'Consumer group for diagnostics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ETL_CRITICAL_PLAN'
     ,group_or_subplan             => 'ORA$DIAGNOSTICS'
     ,cpu_p2                       => 3
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for Oracle diagnostics'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ETL_CRITICAL_PLAN'
     ,group_or_subplan             => 'OTHER_GROUPS'
     ,cpu_p2                       => 3
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for unclassified activity'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ETL_CRITICAL_PLAN'
     ,group_or_subplan             => 'SYS_GROUP'
     ,cpu_p1                       => 75
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for SYS_GROUP'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ETL_GROUP'
     ,comment                      => 'Consumer group for ETL');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ETL_CRITICAL_PLAN'
     ,group_or_subplan             => 'ETL_GROUP'
     ,cpu_p2                       => 35
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for ETL_GROUP'  );
  sys.dbms_resource_manager.submit_pending_area();
end;
/


begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_plan (
      plan                         => 'INTERNAL_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Internally-used plan for disabling the resource manager.');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'INTERNAL_PLAN'
     ,group_or_subplan             => 'OTHER_GROUPS'
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for all other operations'  );
  sys.dbms_resource_manager.submit_pending_area();
end;
/


begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_plan (
      plan                         => 'INTERNAL_QUIESCE'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Plan for quiescing the database.  This plan cannot be activated directly.  To activate, use the quiesce command.');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'INTERNAL_QUIESCE'
     ,group_or_subplan             => 'OTHER_GROUPS'
     ,active_sess_pool_p1          => 0
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for all other operations'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'INTERNAL_QUIESCE'
     ,group_or_subplan             => 'SYS_GROUP'
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for system operations'  );
  sys.dbms_resource_manager.submit_pending_area();
end;
/


begin
  sys.dbms_resource_manager.clear_pending_area();
  sys.dbms_resource_manager.create_pending_area();
  sys.dbms_resource_manager.create_plan (
      plan                         => 'MIXED_WORKLOAD_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Example plan for a mixed workload that prioritizes interactive operations over batch operations.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for automated maintenance tasks.  A directive to this sub-plan should be included in every top-level plan to manage the resources consumed by the automated maintenance tasks.');
  sys.dbms_resource_manager.create_plan (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_mth                      => 'EMPHASIS'
     ,active_sess_pool_mth         => 'ACTIVE_SESS_POOL_ABSOLUTE'
     ,parallel_degree_limit_mth    => 'PARALLEL_DEGREE_LIMIT_ABSOLUTE'
     ,queueing_mth                 => 'FIFO_TIMEOUT'
     ,comment                      => 'Default sub-plan for high-priority, automated maintenance tasks.  This sub-plan is referenced by ORA$AUTOTASK_SUB_PLAN and should not be referenced directly.');
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,comment                      => 'Consumer group for health checks');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HEALTH_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for health check tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SQL_GROUP'
     ,comment                      => 'Consumer group for SQL tuning');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SQL_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for SQL tuning tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_SPACE_GROUP'
     ,comment                      => 'Consumer group for space management advisors');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SPACE_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for space management advisory tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_STATS_GROUP'
     ,comment                      => 'Consumer group for gathering optimizer statistics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_STATS_GROUP'
     ,cpu_p1                       => 25
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for gathering optimizer statistics tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_HIGH_SUB_PLAN'
     ,cpu_p2                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for high-priority automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_URGENT_GROUP'
     ,comment                      => 'Consumer group for urgent maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_URGENT_GROUP'
     ,cpu_p1                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for urgent automated tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,comment                      => 'Consumer group for medium-priority maintenance tasks ');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'ORA$AUTOTASK_SUB_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,cpu_p3                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for medium-priority automated tasks'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'MIXED_WORKLOAD_PLAN'
     ,group_or_subplan             => 'ORA$AUTOTASK_SUB_PLAN'
     ,cpu_p2                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for automated maintenance tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'BATCH_GROUP'
     ,comment                      => 'Consumer group for batch operations');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'MIXED_WORKLOAD_PLAN'
     ,group_or_subplan             => 'BATCH_GROUP'
     ,cpu_p3                       => 100
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for batch operations'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'ORA$DIAGNOSTICS'
     ,comment                      => 'Consumer group for diagnostics');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'MIXED_WORKLOAD_PLAN'
     ,group_or_subplan             => 'ORA$DIAGNOSTICS'
     ,cpu_p2                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for automated diagnostic tasks'  );
  sys.dbms_resource_manager.create_consumer_group (
      consumer_group               => 'INTERACTIVE_GROUP'
     ,comment                      => 'Consumer group for interactive, OLTP operations');
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'MIXED_WORKLOAD_PLAN'
     ,group_or_subplan             => 'INTERACTIVE_GROUP'
     ,cpu_p2                       => 85
     ,switch_group                 => 'BATCH_GROUP'
     ,switch_time                  => 60
     ,switch_estimate              => FALSE
     ,parallel_degree_limit_p1     => 1
     ,comment                      => 'Directive for interactive operations'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'MIXED_WORKLOAD_PLAN'
     ,group_or_subplan             => 'OTHER_GROUPS'
     ,cpu_p2                       => 5
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for all other operations'  );
  sys.dbms_resource_manager.create_plan_directive (
      plan                         => 'MIXED_WORKLOAD_PLAN'
     ,group_or_subplan             => 'SYS_GROUP'
     ,cpu_p1                       => 75
     ,switch_estimate              => FALSE
     ,comment                      => 'Directive for system operations'  );
  sys.dbms_resource_manager.submit_pending_area();
end;
/


CREATE USER ANONYMOUS
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSAUX
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  ACCOUNT UNLOCK;
  -- 1 System Privilege for ANONYMOUS 
  GRANT CREATE SESSION TO ANONYMOUS;


CREATE USER APEX_040000
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSAUX
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  ACCOUNT LOCK;
  -- 2 Roles for APEX_040000 
  GRANT CONNECT TO APEX_040000;
  GRANT RESOURCE TO APEX_040000 WITH ADMIN OPTION;
  ALTER USER APEX_040000 DEFAULT ROLE ALL;
  -- 26 System Privileges for APEX_040000 
  GRANT ALTER DATABASE TO APEX_040000;
  GRANT ALTER SESSION TO APEX_040000;
  GRANT ALTER USER TO APEX_040000;
  GRANT CREATE ANY CONTEXT TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE CLUSTER TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE DIMENSION TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE INDEXTYPE TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE JOB TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE MATERIALIZED VIEW TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE OPERATOR TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE PROCEDURE TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE PUBLIC SYNONYM TO APEX_040000;
  GRANT CREATE ROLE TO APEX_040000;
  GRANT CREATE SEQUENCE TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE SESSION TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE SYNONYM TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE TABLE TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE TABLESPACE TO APEX_040000;
  GRANT CREATE TRIGGER TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE TYPE TO APEX_040000 WITH ADMIN OPTION;
  GRANT CREATE USER TO APEX_040000;
  GRANT CREATE VIEW TO APEX_040000 WITH ADMIN OPTION;
  GRANT DROP PUBLIC SYNONYM TO APEX_040000;
  GRANT DROP TABLESPACE TO APEX_040000;
  GRANT DROP USER TO APEX_040000;
  GRANT UNLIMITED TABLESPACE TO APEX_040000 WITH ADMIN OPTION;


CREATE USER APEX_PUBLIC_USER
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSTEM
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  ACCOUNT LOCK;
  -- 1 System Privilege for APEX_PUBLIC_USER 
  GRANT CREATE SESSION TO APEX_PUBLIC_USER;


CREATE USER CTXSYS
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSAUX
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  PASSWORD EXPIRE
  ACCOUNT LOCK;
  -- 2 Roles for CTXSYS 
  GRANT CTXAPP TO CTXSYS WITH ADMIN OPTION;
  GRANT RESOURCE TO CTXSYS;
  ALTER USER CTXSYS DEFAULT ROLE ALL;
  -- 9 System Privileges for CTXSYS 
  GRANT ALTER SESSION TO CTXSYS;
  GRANT CREATE JOB TO CTXSYS;
  GRANT CREATE PUBLIC SYNONYM TO CTXSYS;
  GRANT CREATE SESSION TO CTXSYS;
  GRANT CREATE SYNONYM TO CTXSYS;
  GRANT CREATE VIEW TO CTXSYS;
  GRANT DROP PUBLIC SYNONYM TO CTXSYS;
  GRANT MANAGE SCHEDULER TO CTXSYS;
  GRANT UNLIMITED TABLESPACE TO CTXSYS;


CREATE USER FLOWS_FILES
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSAUX
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  ACCOUNT LOCK;
  -- 1 System Privilege for FLOWS_FILES 
  GRANT CREATE SYNONYM TO FLOWS_FILES;
  -- 1 Tablespace Quota for FLOWS_FILES 
  ALTER USER FLOWS_FILES QUOTA UNLIMITED ON SYSAUX;


CREATE USER HR
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE USERS
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  PASSWORD EXPIRE
  ACCOUNT LOCK;
  -- 2 Roles for HR 
  GRANT CONNECT TO HR;
  GRANT RESOURCE TO HR;
  ALTER USER HR DEFAULT ROLE ALL;
  -- 7 System Privileges for HR 
  GRANT ALTER SESSION TO HR;
  GRANT CREATE DATABASE LINK TO HR;
  GRANT CREATE SEQUENCE TO HR;
  GRANT CREATE SESSION TO HR;
  GRANT CREATE SYNONYM TO HR;
  GRANT CREATE VIEW TO HR;
  GRANT UNLIMITED TABLESPACE TO HR;
  -- 1 Tablespace Quota for HR 
  ALTER USER HR QUOTA UNLIMITED ON USERS;


CREATE USER MDSYS
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSAUX
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  PASSWORD EXPIRE
  ACCOUNT LOCK;
  -- 2 Roles for MDSYS 
  GRANT CONNECT TO MDSYS;
  GRANT RESOURCE TO MDSYS;
  ALTER USER MDSYS DEFAULT ROLE ALL;
  -- 19 System Privileges for MDSYS 
  GRANT ALTER ANY TABLE TO MDSYS;
  GRANT CREATE ANY TRIGGER TO MDSYS;
  GRANT CREATE INDEXTYPE TO MDSYS;
  GRANT CREATE LIBRARY TO MDSYS;
  GRANT CREATE OPERATOR TO MDSYS;
  GRANT CREATE PROCEDURE TO MDSYS;
  GRANT CREATE PUBLIC SYNONYM TO MDSYS;
  GRANT CREATE SEQUENCE TO MDSYS;
  GRANT CREATE SESSION TO MDSYS;
  GRANT CREATE TABLE TO MDSYS;
  GRANT CREATE TYPE TO MDSYS;
  GRANT CREATE VIEW TO MDSYS;
  GRANT DELETE ANY TABLE TO MDSYS;
  GRANT DROP ANY TRIGGER TO MDSYS;
  GRANT DROP PUBLIC SYNONYM TO MDSYS;
  GRANT FLASHBACK ANY TABLE TO MDSYS;
  GRANT SELECT ANY TABLE TO MDSYS;
  GRANT UNLIMITED TABLESPACE TO MDSYS;
  GRANT UPDATE ANY TABLE TO MDSYS;


CREATE USER OUTLN
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSTEM
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  PASSWORD EXPIRE
  ACCOUNT LOCK;
  -- 1 Role for OUTLN 
  GRANT RESOURCE TO OUTLN;
  ALTER USER OUTLN DEFAULT ROLE ALL;
  -- 3 System Privileges for OUTLN 
  GRANT CREATE SESSION TO OUTLN;
  GRANT EXECUTE ANY PROCEDURE TO OUTLN;
  GRANT UNLIMITED TABLESPACE TO OUTLN;


CREATE USER QQQ
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSTEM
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  ACCOUNT UNLOCK;
  -- 1 Role for QQQ 
  GRANT CONNECT TO QQQ;
  ALTER USER QQQ DEFAULT ROLE ALL;
  -- 1 System Privilege for QQQ 
  GRANT CREATE SESSION TO QQQ;


CREATE USER SSS
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSTEM
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  ACCOUNT UNLOCK;
  -- 1 Role for SSS 
  GRANT CONNECT TO SSS;
  ALTER USER SSS DEFAULT ROLE ALL;
  -- 1 System Privilege for SSS 
  GRANT CREATE SESSION TO SSS;


CREATE USER XDB
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSAUX
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  PASSWORD EXPIRE
  ACCOUNT LOCK;
  -- 2 Roles for XDB 
  GRANT CTXAPP TO XDB;
  GRANT RESOURCE TO XDB;
  ALTER USER XDB DEFAULT ROLE ALL;
  -- 10 System Privileges for XDB 
  GRANT ALTER SESSION TO XDB;
  GRANT CREATE INDEXTYPE TO XDB;
  GRANT CREATE LIBRARY TO XDB;
  GRANT CREATE OPERATOR TO XDB;
  GRANT CREATE PUBLIC SYNONYM TO XDB;
  GRANT CREATE SESSION TO XDB;
  GRANT CREATE VIEW TO XDB;
  GRANT DROP PUBLIC SYNONYM TO XDB;
  GRANT QUERY REWRITE TO XDB;
  GRANT UNLIMITED TABLESPACE TO XDB;


CREATE USER XS$NULL
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSTEM
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  PASSWORD EXPIRE
  ACCOUNT LOCK;



BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'DEFAULT_JOB_CLASS'
     ,resource_consumer_group => NULL
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_RUNS
     ,log_history             => NULL
     ,comments                => 'This is the default job class.'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'SCHED$_LOG_ON_ERRORS_CLASS'
     ,resource_consumer_group => NULL
     ,service                 => NULL
     ,log_history             => NULL
     ,comments                => 'This is the default job if you want minimal logging.'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'DBMS_JOB$'
     ,resource_consumer_group => NULL
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_OFF
     ,log_history             => NULL
     ,comments                => 'This is the job class for jobs created through DBMS_JOB.'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'ORA$AT_JCURG_OS'
     ,resource_consumer_group => 'ORA$AUTOTASK_URGENT_GROUP'
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_FULL
     ,log_history             => 1000000
     ,comments                => 'auto optimizer stats collection'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'ORA$AT_JCNRM_OS'
     ,resource_consumer_group => 'ORA$AUTOTASK_STATS_GROUP'
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_FULL
     ,log_history             => 1000000
     ,comments                => 'auto optimizer stats collection'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'ORA$AT_JCMED_OS'
     ,resource_consumer_group => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_FULL
     ,log_history             => 1000000
     ,comments                => 'auto optimizer stats collection'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'ORA$AT_JCURG_SA'
     ,resource_consumer_group => 'ORA$AUTOTASK_URGENT_GROUP'
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_FULL
     ,log_history             => 1000000
     ,comments                => 'auto space advisor'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'ORA$AT_JCNRM_SA'
     ,resource_consumer_group => 'ORA$AUTOTASK_SPACE_GROUP'
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_FULL
     ,log_history             => 1000000
     ,comments                => 'auto space advisor'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'ORA$AT_JCMED_SA'
     ,resource_consumer_group => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_FULL
     ,log_history             => 1000000
     ,comments                => 'auto space advisor'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'ORA$AT_JCURG_SQ'
     ,resource_consumer_group => 'ORA$AUTOTASK_URGENT_GROUP'
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_FULL
     ,log_history             => 1000000
     ,comments                => 'sql tuning advisor'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'ORA$AT_JCNRM_SQ'
     ,resource_consumer_group => 'ORA$AUTOTASK_SQL_GROUP'
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_FULL
     ,log_history             => 1000000
     ,comments                => 'sql tuning advisor'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'ORA$AT_JCMED_SQ'
     ,resource_consumer_group => 'ORA$AUTOTASK_MEDIUM_GROUP'
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_FULL
     ,log_history             => 1000000
     ,comments                => 'sql tuning advisor'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'AQ$_PROPAGATION_JOB_CLASS'
     ,resource_consumer_group => NULL
     ,service                 => NULL
     ,logging_level           => SYS.DBMS_SCHEDULER.LOGGING_RUNS
     ,log_history             => NULL
     ,comments                => 'Default job class for AQ propagation jobs'
    );
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_JOB_CLASS
    (
      job_class_name          => 'XMLDB_NFS_JOBCLASS'
     ,resource_consumer_group => NULL
     ,service                 => NULL
     ,log_history             => NULL
     ,comments                => NULL
    );
END;
/

BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW
    (
       window_name     => 'MONDAY_WINDOW'
      ,start_date      => NULL
      ,repeat_interval => 'freq=daily;byday=MON;byhour=22;byminute=0; bysecond=0'
      ,end_date        => NULL
      ,resource_plan   => 'DEFAULT_MAINTENANCE_PLAN'
      ,duration        => to_dsInterval('+000 04:00:00')
      ,window_priority => 'LOW'
      ,comments        => 'Monday window for maintenance tasks'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.MONDAY_WINDOW');

END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW
    (
       window_name     => 'TUESDAY_WINDOW'
      ,start_date      => NULL
      ,repeat_interval => 'freq=daily;byday=TUE;byhour=22;byminute=0; bysecond=0'
      ,end_date        => NULL
      ,resource_plan   => 'DEFAULT_MAINTENANCE_PLAN'
      ,duration        => to_dsInterval('+000 04:00:00')
      ,window_priority => 'LOW'
      ,comments        => 'Tuesday window for maintenance tasks'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.TUESDAY_WINDOW');

END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW
    (
       window_name     => 'WEDNESDAY_WINDOW'
      ,start_date      => NULL
      ,repeat_interval => 'freq=daily;byday=WED;byhour=22;byminute=0; bysecond=0'
      ,end_date        => NULL
      ,resource_plan   => 'DEFAULT_MAINTENANCE_PLAN'
      ,duration        => to_dsInterval('+000 04:00:00')
      ,window_priority => 'LOW'
      ,comments        => 'Wednesday window for maintenance tasks'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.WEDNESDAY_WINDOW');

END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW
    (
       window_name     => 'THURSDAY_WINDOW'
      ,start_date      => NULL
      ,repeat_interval => 'freq=daily;byday=THU;byhour=22;byminute=0; bysecond=0'
      ,end_date        => NULL
      ,resource_plan   => 'DEFAULT_MAINTENANCE_PLAN'
      ,duration        => to_dsInterval('+000 04:00:00')
      ,window_priority => 'LOW'
      ,comments        => 'Thursday window for maintenance tasks'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.THURSDAY_WINDOW');

END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW
    (
       window_name     => 'FRIDAY_WINDOW'
      ,start_date      => NULL
      ,repeat_interval => 'freq=daily;byday=FRI;byhour=22;byminute=0; bysecond=0'
      ,end_date        => NULL
      ,resource_plan   => 'DEFAULT_MAINTENANCE_PLAN'
      ,duration        => to_dsInterval('+000 04:00:00')
      ,window_priority => 'LOW'
      ,comments        => 'Friday window for maintenance tasks'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.FRIDAY_WINDOW');

END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW
    (
       window_name     => 'SATURDAY_WINDOW'
      ,start_date      => NULL
      ,repeat_interval => 'freq=daily;byday=SAT;byhour=6;byminute=0; bysecond=0'
      ,end_date        => NULL
      ,resource_plan   => 'DEFAULT_MAINTENANCE_PLAN'
      ,duration        => to_dsInterval('+000 20:00:00')
      ,window_priority => 'LOW'
      ,comments        => 'Saturday window for maintenance tasks'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.SATURDAY_WINDOW');

END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW
    (
       window_name     => 'SUNDAY_WINDOW'
      ,start_date      => NULL
      ,repeat_interval => 'freq=daily;byday=SUN;byhour=6;byminute=0; bysecond=0'
      ,end_date        => NULL
      ,resource_plan   => 'DEFAULT_MAINTENANCE_PLAN'
      ,duration        => to_dsInterval('+000 20:00:00')
      ,window_priority => 'LOW'
      ,comments        => 'Sunday window for maintenance tasks'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.SUNDAY_WINDOW');

END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW
    (
       window_name     => 'WEEKNIGHT_WINDOW'
      ,start_date      => NULL
      ,repeat_interval => 'freq=daily;byday=MON,TUE,WED,THU,FRI;byhour=22;byminute=0; bysecond=0'
      ,end_date        => NULL
      ,resource_plan   => NULL
      ,duration        => to_dsInterval('+000 08:00:00')
      ,window_priority => 'LOW'
      ,comments        => 'Weeknight window - for compatibility only'
    );
  SYS.DBMS_SCHEDULER.DISABLE
    (name => 'SYS.WEEKNIGHT_WINDOW');

END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW
    (
       window_name     => 'WEEKEND_WINDOW'
      ,start_date      => NULL
      ,repeat_interval => 'freq=daily;byday=SAT;byhour=0;byminute=0;bysecond=0'
      ,end_date        => NULL
      ,resource_plan   => NULL
      ,duration        => to_dsInterval('+002 00:00:00')
      ,window_priority => 'LOW'
      ,comments        => 'Weekend window - for compatibility only'
    );
  SYS.DBMS_SCHEDULER.DISABLE
    (name => 'SYS.WEEKEND_WINDOW');

END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW_GROUP
    (
       group_name     => 'MAINTENANCE_WINDOW_GROUP'
      ,window_list    => NULL
      ,comments       => 'Window group for Automated Maintenance'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.MAINTENANCE_WINDOW_GROUP');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.MAINTENANCE_WINDOW_GROUP',
     window_list => 'MONDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.MAINTENANCE_WINDOW_GROUP',
     window_list => 'TUESDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.MAINTENANCE_WINDOW_GROUP',
     window_list => 'WEDNESDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.MAINTENANCE_WINDOW_GROUP',
     window_list => 'THURSDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.MAINTENANCE_WINDOW_GROUP',
     window_list => 'FRIDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.MAINTENANCE_WINDOW_GROUP',
     window_list => 'SATURDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.MAINTENANCE_WINDOW_GROUP',
     window_list => 'SUNDAY_WINDOW');
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW_GROUP
    (
       group_name     => 'ORA$AT_WGRP_OS'
      ,window_list    => NULL
      ,comments       => 'auto optimizer stats collection'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.ORA$AT_WGRP_OS');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_OS',
     window_list => 'MONDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_OS',
     window_list => 'TUESDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_OS',
     window_list => 'WEDNESDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_OS',
     window_list => 'THURSDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_OS',
     window_list => 'FRIDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_OS',
     window_list => 'SATURDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_OS',
     window_list => 'SUNDAY_WINDOW');
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW_GROUP
    (
       group_name     => 'ORA$AT_WGRP_SA'
      ,window_list    => NULL
      ,comments       => 'auto space advisor'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.ORA$AT_WGRP_SA');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SA',
     window_list => 'MONDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SA',
     window_list => 'TUESDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SA',
     window_list => 'WEDNESDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SA',
     window_list => 'THURSDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SA',
     window_list => 'FRIDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SA',
     window_list => 'SATURDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SA',
     window_list => 'SUNDAY_WINDOW');
END;
/


BEGIN
  SYS.DBMS_SCHEDULER.CREATE_WINDOW_GROUP
    (
       group_name     => 'ORA$AT_WGRP_SQ'
      ,window_list    => NULL
      ,comments       => 'sql tuning advisor'
    );
  SYS.DBMS_SCHEDULER.ENABLE
    (name => 'SYS.ORA$AT_WGRP_SQ');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SQ',
     window_list => 'MONDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SQ',
     window_list => 'TUESDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SQ',
     window_list => 'WEDNESDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SQ',
     window_list => 'THURSDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SQ',
     window_list => 'FRIDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SQ',
     window_list => 'SATURDAY_WINDOW');
END;
/
BEGIN
  DBMS_SCHEDULER.ADD_WINDOW_GROUP_MEMBER
    (group_name  => 'SYS.ORA$AT_WGRP_SQ',
     window_list => 'SUNDAY_WINDOW');
END;
/


CREATE OR REPLACE TRIGGER MDSYS.sdo_drop_user
after drop on DATABASE
declare
   stmt varchar2(200);
   cnt number;
BEGIN
     if sys.dbms_standard.dictionary_obj_type = 'USER' THEN
       stmt := 'DELETE FROM SDO_GEOM_METADATA_TABLE ' ||
     ' WHERE SDO_OWNER = :owner ';
       EXECUTE IMMEDIATE stmt USING sys.dbms_standard.dictionary_obj_name;

       stmt := 'DELETE FROM SDO_MAPS_TABLE ' ||
    ' WHERE SDO_OWNER = :owner ';
       EXECUTE IMMEDIATE stmt USING sys.dbms_standard.dictionary_obj_name;

       stmt := 'DELETE FROM SDO_CACHED_MAPS_TABLE ' ||
    ' WHERE SDO_OWNER = :owner ';
       EXECUTE IMMEDIATE stmt USING sys.dbms_standard.dictionary_obj_name;

       stmt := 'DELETE FROM SDO_STYLES_TABLE ' ||
    ' WHERE SDO_OWNER = :owner ';
       EXECUTE IMMEDIATE stmt USING sys.dbms_standard.dictionary_obj_name;

       stmt := 'DELETE FROM SDO_THEMES_TABLE ' ||
   ' WHERE SDO_OWNER = :owner ';
       EXECUTE IMMEDIATE stmt USING sys.dbms_standard.dictionary_obj_name;

       stmt := 'DELETE FROM SDO_LRS_METADATA_TABLE ' ||
   ' WHERE SDO_OWNER = :owner ';
       EXECUTE IMMEDIATE stmt USING sys.dbms_standard.dictionary_obj_name;

       stmt := 'DELETE FROM SDO_TOPO_METADATA_TABLE ' ||
   ' WHERE SDO_OWNER = :owner ';
       EXECUTE IMMEDIATE stmt USING sys.dbms_standard.dictionary_obj_name;

       stmt := 'DELETE FROM SDO_ANNOTATION_TEXT_METADATA ' ||
   ' WHERE F_TABLE_SCHEMA = :owner ';
       EXECUTE IMMEDIATE stmt USING sys.dbms_standard.dictionary_obj_name;
    end if;
end;
/
SHOW ERRORS;


CREATE OR REPLACE TRIGGER MDSYS.sdo_st_syn_create
  BEFORE CREATE ON DATABASE
declare
 error boolean;
  st_syn_detected EXCEPTION;
   PRAGMA EXCEPTION_INIT(st_syn_detected, -995);
 BEGIN
   if((sys.dbms_standard.dictionary_obj_type!='SYNONYM')or(sys.dbms_standard.dictionary_obj_owner!='PUBLIC'))
   then
     return;
   end if;
   error :=
      CASE sys.dbms_standard.dictionary_obj_name
         WHEN 'ST_GEOMETRY' THEN TRUE
         WHEN 'ST_SURFACE' THEN TRUE
         WHEN 'ST_POLYGON' THEN TRUE
         WHEN 'ST_POINT' THEN TRUE
         WHEN 'ST_MULTISURFACE' THEN TRUE
         WHEN 'ST_MULTIPOINT' THEN TRUE
         WHEN 'ST_MULTILINESTRING' THEN TRUE
         WHEN 'ST_MULTICURVE' THEN TRUE
         WHEN 'ST_LINESTRING' THEN TRUE
         WHEN 'ST_GEOMCOLLECTION' THEN TRUE
         WHEN 'ST_CURVE' THEN TRUE
         WHEN 'ST_CURVEPOLYGON' THEN TRUE
         WHEN 'ST_COMPOUNDCURVE' THEN TRUE
         WHEN 'ST_CIRCULARSTRING' THEN TRUE
         WHEN 'ST_INTERSECTS' THEN TRUE
         WHEN 'ST_RELATE' THEN TRUE
         WHEN 'ST_TOUCH' THEN TRUE
         WHEN 'ST_CONTAINS' THEN TRUE
         WHEN 'ST_COVERS' THEN TRUE
         WHEN 'ST_COVEREDBY' THEN TRUE
         WHEN 'ST_INSIDE' THEN TRUE
         WHEN 'ST_OVERLAP' THEN TRUE
         WHEN 'ST_OVERLAPS' THEN TRUE
         WHEN 'ST_EQUAL' THEN TRUE
         WHEN 'ST_OVERLAPBDYDISJOINT' THEN TRUE
         WHEN 'ST_OVERLAPBDYINTERSECT' THEN TRUE
         WHEN 'ST_GEOMETRY_ARRAY' THEN TRUE
         WHEN 'ST_POINT_ARRAY' THEN TRUE
         WHEN 'ST_CURVE_ARRAY' THEN TRUE
         WHEN 'ST_SURFACE_ARRAY' THEN TRUE
         WHEN 'ST_LINESTRING_ARRAY' THEN TRUE
         WHEN 'ST_POLYGON_ARRAY' THEN TRUE
         ELSE FALSE
      END;

   if(error) then
     raise st_syn_detected;

   end if;
 END;
/
SHOW ERRORS;


CREATE ROLE EXECUTE_CATALOG_ROLE NOT IDENTIFIED;

GRANT HS_ADMIN_EXECUTE_ROLE TO EXECUTE_CATALOG_ROLE;


CREATE ROLE EXP_FULL_DATABASE NOT IDENTIFIED;

BEGIN
SYS.DBMS_RESOURCE_MANAGER_PRIVS.GRANT_SYSTEM_PRIVILEGE
  (GRANTEE_NAME   => 'EXP_FULL_DATABASE', 
   PRIVILEGE_NAME => 'ADMINISTER_RESOURCE_MANAGER',
   ADMIN_OPTION   => FALSE);
END;
/
GRANT ADMINISTER SQL MANAGEMENT OBJECT TO EXP_FULL_DATABASE;
GRANT BACKUP ANY TABLE TO EXP_FULL_DATABASE;
GRANT CREATE SESSION TO EXP_FULL_DATABASE;
GRANT CREATE TABLE TO EXP_FULL_DATABASE;
GRANT EXECUTE ANY PROCEDURE TO EXP_FULL_DATABASE;
GRANT EXECUTE ANY TYPE TO EXP_FULL_DATABASE;
GRANT READ ANY FILE GROUP TO EXP_FULL_DATABASE;
GRANT RESUMABLE TO EXP_FULL_DATABASE;
GRANT SELECT ANY SEQUENCE TO EXP_FULL_DATABASE;
GRANT SELECT ANY TABLE TO EXP_FULL_DATABASE;
GRANT EXECUTE_CATALOG_ROLE TO EXP_FULL_DATABASE;
GRANT SELECT_CATALOG_ROLE TO EXP_FULL_DATABASE;


CREATE ROLE HS_ADMIN_ROLE NOT IDENTIFIED;

GRANT HS_ADMIN_EXECUTE_ROLE TO HS_ADMIN_ROLE;
GRANT HS_ADMIN_SELECT_ROLE TO HS_ADMIN_ROLE;


CREATE ROLE IMP_FULL_DATABASE NOT IDENTIFIED;

GRANT ADMINISTER DATABASE TRIGGER TO IMP_FULL_DATABASE;
BEGIN
SYS.DBMS_RESOURCE_MANAGER_PRIVS.GRANT_SYSTEM_PRIVILEGE
  (GRANTEE_NAME   => 'IMP_FULL_DATABASE', 
   PRIVILEGE_NAME => 'ADMINISTER_RESOURCE_MANAGER',
   ADMIN_OPTION   => FALSE);
END;
/
GRANT ADMINISTER SQL MANAGEMENT OBJECT TO IMP_FULL_DATABASE;
GRANT ALTER ANY PROCEDURE TO IMP_FULL_DATABASE;
GRANT ALTER ANY TABLE TO IMP_FULL_DATABASE;
GRANT ALTER ANY TRIGGER TO IMP_FULL_DATABASE;
GRANT ALTER ANY TYPE TO IMP_FULL_DATABASE;
GRANT ALTER DATABASE TO IMP_FULL_DATABASE;
GRANT ALTER PROFILE TO IMP_FULL_DATABASE;
GRANT ALTER RESOURCE COST TO IMP_FULL_DATABASE;
GRANT ALTER USER TO IMP_FULL_DATABASE;
GRANT ANALYZE ANY TO IMP_FULL_DATABASE;
GRANT AUDIT ANY TO IMP_FULL_DATABASE;
GRANT AUDIT SYSTEM TO IMP_FULL_DATABASE;
GRANT BECOME USER TO IMP_FULL_DATABASE;
GRANT COMMENT ANY TABLE TO IMP_FULL_DATABASE;
GRANT CREATE ANY CLUSTER TO IMP_FULL_DATABASE;
GRANT CREATE ANY CONTEXT TO IMP_FULL_DATABASE;
GRANT CREATE ANY DIMENSION TO IMP_FULL_DATABASE;
GRANT CREATE ANY DIRECTORY TO IMP_FULL_DATABASE;
GRANT CREATE ANY INDEX TO IMP_FULL_DATABASE;
GRANT CREATE ANY INDEXTYPE TO IMP_FULL_DATABASE;
GRANT CREATE ANY LIBRARY TO IMP_FULL_DATABASE;
GRANT CREATE ANY MATERIALIZED VIEW TO IMP_FULL_DATABASE;
GRANT CREATE ANY OPERATOR TO IMP_FULL_DATABASE;
GRANT CREATE ANY PROCEDURE TO IMP_FULL_DATABASE;
GRANT CREATE ANY SEQUENCE TO IMP_FULL_DATABASE;
GRANT CREATE ANY SQL PROFILE TO IMP_FULL_DATABASE;
GRANT CREATE ANY SYNONYM TO IMP_FULL_DATABASE;
GRANT CREATE ANY TABLE TO IMP_FULL_DATABASE;
GRANT CREATE ANY TRIGGER TO IMP_FULL_DATABASE;
GRANT CREATE ANY TYPE TO IMP_FULL_DATABASE;
GRANT CREATE ANY VIEW TO IMP_FULL_DATABASE;
GRANT CREATE DATABASE LINK TO IMP_FULL_DATABASE;
GRANT CREATE PROFILE TO IMP_FULL_DATABASE;
GRANT CREATE PUBLIC DATABASE LINK TO IMP_FULL_DATABASE;
GRANT CREATE PUBLIC SYNONYM TO IMP_FULL_DATABASE;
GRANT CREATE ROLE TO IMP_FULL_DATABASE;
GRANT CREATE ROLLBACK SEGMENT TO IMP_FULL_DATABASE;
GRANT CREATE SESSION TO IMP_FULL_DATABASE;
GRANT CREATE TABLESPACE TO IMP_FULL_DATABASE;
GRANT CREATE USER TO IMP_FULL_DATABASE;
GRANT DELETE ANY TABLE TO IMP_FULL_DATABASE;
GRANT DROP ANY CLUSTER TO IMP_FULL_DATABASE;
GRANT DROP ANY CONTEXT TO IMP_FULL_DATABASE;
GRANT DROP ANY DIMENSION TO IMP_FULL_DATABASE;
GRANT DROP ANY DIRECTORY TO IMP_FULL_DATABASE;
GRANT DROP ANY INDEX TO IMP_FULL_DATABASE;
GRANT DROP ANY INDEXTYPE TO IMP_FULL_DATABASE;
GRANT DROP ANY LIBRARY TO IMP_FULL_DATABASE;
GRANT DROP ANY MATERIALIZED VIEW TO IMP_FULL_DATABASE;
GRANT DROP ANY OPERATOR TO IMP_FULL_DATABASE;
GRANT DROP ANY OUTLINE TO IMP_FULL_DATABASE;
GRANT DROP ANY PROCEDURE TO IMP_FULL_DATABASE;
GRANT DROP ANY ROLE TO IMP_FULL_DATABASE;
GRANT DROP ANY SEQUENCE TO IMP_FULL_DATABASE;
GRANT DROP ANY SQL PROFILE TO IMP_FULL_DATABASE;
GRANT DROP ANY SYNONYM TO IMP_FULL_DATABASE;
GRANT DROP ANY TABLE TO IMP_FULL_DATABASE;
GRANT DROP ANY TRIGGER TO IMP_FULL_DATABASE;
GRANT DROP ANY TYPE TO IMP_FULL_DATABASE;
GRANT DROP ANY VIEW TO IMP_FULL_DATABASE;
GRANT DROP PROFILE TO IMP_FULL_DATABASE;
GRANT DROP PUBLIC DATABASE LINK TO IMP_FULL_DATABASE;
GRANT DROP PUBLIC SYNONYM TO IMP_FULL_DATABASE;
GRANT DROP ROLLBACK SEGMENT TO IMP_FULL_DATABASE;
GRANT DROP TABLESPACE TO IMP_FULL_DATABASE;
GRANT DROP USER TO IMP_FULL_DATABASE;
GRANT EXECUTE ANY OPERATOR TO IMP_FULL_DATABASE;
GRANT EXECUTE ANY PROCEDURE TO IMP_FULL_DATABASE;
GRANT EXECUTE ANY TYPE TO IMP_FULL_DATABASE;
GRANT GLOBAL QUERY REWRITE TO IMP_FULL_DATABASE;
GRANT GRANT ANY OBJECT PRIVILEGE TO IMP_FULL_DATABASE;
GRANT GRANT ANY PRIVILEGE TO IMP_FULL_DATABASE;
GRANT GRANT ANY ROLE TO IMP_FULL_DATABASE;
GRANT INSERT ANY TABLE TO IMP_FULL_DATABASE;
BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'MANAGE_ANY',
  GRANTEE      => 'IMP_FULL_DATABASE',
  ADMIN_OPTION => FALSE);
END;
/
GRANT RESUMABLE TO IMP_FULL_DATABASE;
GRANT SELECT ANY TABLE TO IMP_FULL_DATABASE;
GRANT UPDATE ANY TABLE TO IMP_FULL_DATABASE;
GRANT EXECUTE_CATALOG_ROLE TO IMP_FULL_DATABASE;
GRANT SELECT_CATALOG_ROLE TO IMP_FULL_DATABASE;


CREATE ROLE LOGSTDBY_ADMINISTRATOR NOT IDENTIFIED;

GRANT UNLIMITED TABLESPACE TO LOGSTDBY_ADMINISTRATOR;
GRANT RESOURCE TO LOGSTDBY_ADMINISTRATOR;


CREATE ROLE OEM_MONITOR NOT IDENTIFIED;

GRANT ADVISOR TO OEM_MONITOR;
GRANT ANALYZE ANY TO OEM_MONITOR;
GRANT ANALYZE ANY DICTIONARY TO OEM_MONITOR;
GRANT CREATE JOB TO OEM_MONITOR;
GRANT CREATE SESSION TO OEM_MONITOR;
BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'MANAGE_ANY',
  GRANTEE      => 'OEM_MONITOR',
  ADMIN_OPTION => FALSE);
END;
/
GRANT SELECT ANY DICTIONARY TO OEM_MONITOR;
GRANT SELECT_CATALOG_ROLE TO OEM_MONITOR;


CREATE ROLE DATAPUMP_EXP_FULL_DATABASE NOT IDENTIFIED;

GRANT CREATE SESSION TO DATAPUMP_EXP_FULL_DATABASE;
GRANT CREATE TABLE TO DATAPUMP_EXP_FULL_DATABASE;
GRANT EXP_FULL_DATABASE TO DATAPUMP_EXP_FULL_DATABASE;


CREATE ROLE DATAPUMP_IMP_FULL_DATABASE NOT IDENTIFIED;

GRANT ALTER DATABASE TO DATAPUMP_IMP_FULL_DATABASE;
GRANT ALTER PROFILE TO DATAPUMP_IMP_FULL_DATABASE;
GRANT ALTER RESOURCE COST TO DATAPUMP_IMP_FULL_DATABASE;
GRANT ALTER USER TO DATAPUMP_IMP_FULL_DATABASE;
GRANT AUDIT ANY TO DATAPUMP_IMP_FULL_DATABASE;
GRANT AUDIT SYSTEM TO DATAPUMP_IMP_FULL_DATABASE;
GRANT CREATE PROFILE TO DATAPUMP_IMP_FULL_DATABASE;
GRANT CREATE SESSION TO DATAPUMP_IMP_FULL_DATABASE;
GRANT DELETE ANY TABLE TO DATAPUMP_IMP_FULL_DATABASE;
GRANT EXECUTE ANY OPERATOR TO DATAPUMP_IMP_FULL_DATABASE;
GRANT GRANT ANY OBJECT PRIVILEGE TO DATAPUMP_IMP_FULL_DATABASE;
GRANT GRANT ANY PRIVILEGE TO DATAPUMP_IMP_FULL_DATABASE;
GRANT GRANT ANY ROLE TO DATAPUMP_IMP_FULL_DATABASE;
GRANT SELECT ANY TABLE TO DATAPUMP_IMP_FULL_DATABASE;
GRANT EXP_FULL_DATABASE TO DATAPUMP_IMP_FULL_DATABASE;
GRANT IMP_FULL_DATABASE TO DATAPUMP_IMP_FULL_DATABASE;


CREATE ROLE DBA NOT IDENTIFIED;

GRANT ADMINISTER ANY SQL TUNING SET TO DBA WITH ADMIN OPTION;
GRANT ADMINISTER DATABASE TRIGGER TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RESOURCE_MANAGER_PRIVS.GRANT_SYSTEM_PRIVILEGE
  (GRANTEE_NAME   => 'DBA', 
   PRIVILEGE_NAME => 'ADMINISTER_RESOURCE_MANAGER',
   ADMIN_OPTION   => TRUE);
END;
/
GRANT ADMINISTER SQL MANAGEMENT OBJECT TO DBA WITH ADMIN OPTION;
GRANT ADMINISTER SQL TUNING SET TO DBA WITH ADMIN OPTION;
GRANT ADVISOR TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY ASSEMBLY TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY CLUSTER TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY CUBE TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY CUBE DIMENSION TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY DIMENSION TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY EDITION TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.ALTER_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT ALTER ANY INDEX TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY INDEXTYPE TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY LIBRARY TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY MATERIALIZED VIEW TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY MINING MODEL TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY OPERATOR TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY OUTLINE TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY PROCEDURE TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY ROLE TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.ALTER_ANY_RULE,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.ALTER_ANY_RULE_SET,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT ALTER ANY SEQUENCE TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY SQL PROFILE TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY TRIGGER TO DBA WITH ADMIN OPTION;
GRANT ALTER ANY TYPE TO DBA WITH ADMIN OPTION;
GRANT ALTER DATABASE TO DBA WITH ADMIN OPTION;
GRANT ALTER PROFILE TO DBA WITH ADMIN OPTION;
GRANT ALTER RESOURCE COST TO DBA WITH ADMIN OPTION;
GRANT ALTER ROLLBACK SEGMENT TO DBA WITH ADMIN OPTION;
GRANT ALTER SESSION TO DBA WITH ADMIN OPTION;
GRANT ALTER SYSTEM TO DBA WITH ADMIN OPTION;
GRANT ALTER TABLESPACE TO DBA WITH ADMIN OPTION;
GRANT ALTER USER TO DBA WITH ADMIN OPTION;
GRANT ANALYZE ANY TO DBA WITH ADMIN OPTION;
GRANT ANALYZE ANY DICTIONARY TO DBA WITH ADMIN OPTION;
GRANT AUDIT ANY TO DBA WITH ADMIN OPTION;
GRANT AUDIT SYSTEM TO DBA WITH ADMIN OPTION;
GRANT BACKUP ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT BECOME USER TO DBA WITH ADMIN OPTION;
GRANT CHANGE NOTIFICATION TO DBA WITH ADMIN OPTION;
GRANT COMMENT ANY MINING MODEL TO DBA WITH ADMIN OPTION;
GRANT COMMENT ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY ASSEMBLY TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY CLUSTER TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY CONTEXT TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY CUBE TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY CUBE BUILD PROCESS TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY CUBE DIMENSION TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY DIMENSION TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY DIRECTORY TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY EDITION TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT CREATE ANY INDEX TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY INDEXTYPE TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY JOB TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY LIBRARY TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY MATERIALIZED VIEW TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY MEASURE FOLDER TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY MINING MODEL TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY OPERATOR TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY OUTLINE TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY PROCEDURE TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_ANY_RULE,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_ANY_RULE_SET,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT CREATE ANY SEQUENCE TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY SQL PROFILE TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY SYNONYM TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY TRIGGER TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY TYPE TO DBA WITH ADMIN OPTION;
GRANT CREATE ANY VIEW TO DBA WITH ADMIN OPTION;
GRANT CREATE ASSEMBLY TO DBA WITH ADMIN OPTION;
GRANT CREATE CLUSTER TO DBA WITH ADMIN OPTION;
GRANT CREATE CUBE TO DBA WITH ADMIN OPTION;
GRANT CREATE CUBE BUILD PROCESS TO DBA WITH ADMIN OPTION;
GRANT CREATE CUBE DIMENSION TO DBA WITH ADMIN OPTION;
GRANT CREATE DATABASE LINK TO DBA WITH ADMIN OPTION;
GRANT CREATE DIMENSION TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_EVALUATION_CONTEXT_OBJ,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT CREATE EXTERNAL JOB TO DBA WITH ADMIN OPTION;
GRANT CREATE INDEXTYPE TO DBA WITH ADMIN OPTION;
GRANT CREATE JOB TO DBA WITH ADMIN OPTION;
GRANT CREATE LIBRARY TO DBA WITH ADMIN OPTION;
GRANT CREATE MATERIALIZED VIEW TO DBA WITH ADMIN OPTION;
GRANT CREATE MEASURE FOLDER TO DBA WITH ADMIN OPTION;
GRANT CREATE MINING MODEL TO DBA WITH ADMIN OPTION;
GRANT CREATE OPERATOR TO DBA WITH ADMIN OPTION;
GRANT CREATE PROCEDURE TO DBA WITH ADMIN OPTION;
GRANT CREATE PROFILE TO DBA WITH ADMIN OPTION;
GRANT CREATE PUBLIC DATABASE LINK TO DBA WITH ADMIN OPTION;
GRANT CREATE PUBLIC SYNONYM TO DBA WITH ADMIN OPTION;
GRANT CREATE ROLE TO DBA WITH ADMIN OPTION;
GRANT CREATE ROLLBACK SEGMENT TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_RULE_OBJ,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_RULE_SET_OBJ,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT CREATE SEQUENCE TO DBA WITH ADMIN OPTION;
GRANT CREATE SESSION TO DBA WITH ADMIN OPTION;
GRANT CREATE SYNONYM TO DBA WITH ADMIN OPTION;
GRANT CREATE TABLE TO DBA WITH ADMIN OPTION;
GRANT CREATE TABLESPACE TO DBA WITH ADMIN OPTION;
GRANT CREATE TRIGGER TO DBA WITH ADMIN OPTION;
GRANT CREATE TYPE TO DBA WITH ADMIN OPTION;
GRANT CREATE USER TO DBA WITH ADMIN OPTION;
GRANT CREATE VIEW TO DBA WITH ADMIN OPTION;
GRANT DEBUG ANY PROCEDURE TO DBA WITH ADMIN OPTION;
GRANT DEBUG CONNECT SESSION TO DBA WITH ADMIN OPTION;
GRANT DELETE ANY CUBE DIMENSION TO DBA WITH ADMIN OPTION;
GRANT DELETE ANY MEASURE FOLDER TO DBA WITH ADMIN OPTION;
GRANT DELETE ANY TABLE TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'DEQUEUE_ANY',
  GRANTEE      => 'DBA',
  ADMIN_OPTION => TRUE);
END;
/
GRANT DROP ANY ASSEMBLY TO DBA WITH ADMIN OPTION;
GRANT DROP ANY CLUSTER TO DBA WITH ADMIN OPTION;
GRANT DROP ANY CONTEXT TO DBA WITH ADMIN OPTION;
GRANT DROP ANY CUBE TO DBA WITH ADMIN OPTION;
GRANT DROP ANY CUBE BUILD PROCESS TO DBA WITH ADMIN OPTION;
GRANT DROP ANY CUBE DIMENSION TO DBA WITH ADMIN OPTION;
GRANT DROP ANY DIMENSION TO DBA WITH ADMIN OPTION;
GRANT DROP ANY DIRECTORY TO DBA WITH ADMIN OPTION;
GRANT DROP ANY EDITION TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.DROP_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT DROP ANY INDEX TO DBA WITH ADMIN OPTION;
GRANT DROP ANY INDEXTYPE TO DBA WITH ADMIN OPTION;
GRANT DROP ANY LIBRARY TO DBA WITH ADMIN OPTION;
GRANT DROP ANY MATERIALIZED VIEW TO DBA WITH ADMIN OPTION;
GRANT DROP ANY MEASURE FOLDER TO DBA WITH ADMIN OPTION;
GRANT DROP ANY MINING MODEL TO DBA WITH ADMIN OPTION;
GRANT DROP ANY OPERATOR TO DBA WITH ADMIN OPTION;
GRANT DROP ANY OUTLINE TO DBA WITH ADMIN OPTION;
GRANT DROP ANY PROCEDURE TO DBA WITH ADMIN OPTION;
GRANT DROP ANY ROLE TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.DROP_ANY_RULE,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.DROP_ANY_RULE_SET,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT DROP ANY SEQUENCE TO DBA WITH ADMIN OPTION;
GRANT DROP ANY SQL PROFILE TO DBA WITH ADMIN OPTION;
GRANT DROP ANY SYNONYM TO DBA WITH ADMIN OPTION;
GRANT DROP ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT DROP ANY TRIGGER TO DBA WITH ADMIN OPTION;
GRANT DROP ANY TYPE TO DBA WITH ADMIN OPTION;
GRANT DROP ANY VIEW TO DBA WITH ADMIN OPTION;
GRANT DROP PROFILE TO DBA WITH ADMIN OPTION;
GRANT DROP PUBLIC DATABASE LINK TO DBA WITH ADMIN OPTION;
GRANT DROP PUBLIC SYNONYM TO DBA WITH ADMIN OPTION;
GRANT DROP ROLLBACK SEGMENT TO DBA WITH ADMIN OPTION;
GRANT DROP TABLESPACE TO DBA WITH ADMIN OPTION;
GRANT DROP USER TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'ENQUEUE_ANY',
  GRANTEE      => 'DBA',
  ADMIN_OPTION => TRUE);
END;
/
GRANT EXECUTE ANY ASSEMBLY TO DBA WITH ADMIN OPTION;
GRANT EXECUTE ANY CLASS TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.EXECUTE_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT EXECUTE ANY INDEXTYPE TO DBA WITH ADMIN OPTION;
GRANT EXECUTE ANY LIBRARY TO DBA WITH ADMIN OPTION;
GRANT EXECUTE ANY OPERATOR TO DBA WITH ADMIN OPTION;
GRANT EXECUTE ANY PROCEDURE TO DBA WITH ADMIN OPTION;
GRANT EXECUTE ANY PROGRAM TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.EXECUTE_ANY_RULE,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.EXECUTE_ANY_RULE_SET,
  GRANTEE      => 'DBA',
  GRANT_OPTION => TRUE);
END;
/
GRANT EXECUTE ANY TYPE TO DBA WITH ADMIN OPTION;
GRANT EXECUTE ASSEMBLY TO DBA WITH ADMIN OPTION;
GRANT EXPORT FULL DATABASE TO DBA WITH ADMIN OPTION;
GRANT FLASHBACK ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT FLASHBACK ARCHIVE ADMINISTER TO DBA WITH ADMIN OPTION;
GRANT FORCE ANY TRANSACTION TO DBA WITH ADMIN OPTION;
GRANT FORCE TRANSACTION TO DBA WITH ADMIN OPTION;
GRANT GLOBAL QUERY REWRITE TO DBA WITH ADMIN OPTION;
GRANT GRANT ANY OBJECT PRIVILEGE TO DBA WITH ADMIN OPTION;
GRANT GRANT ANY PRIVILEGE TO DBA WITH ADMIN OPTION;
GRANT GRANT ANY ROLE TO DBA WITH ADMIN OPTION;
GRANT IMPORT FULL DATABASE TO DBA WITH ADMIN OPTION;
GRANT INSERT ANY CUBE DIMENSION TO DBA WITH ADMIN OPTION;
GRANT INSERT ANY MEASURE FOLDER TO DBA WITH ADMIN OPTION;
GRANT INSERT ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT LOCK ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT MANAGE ANY FILE GROUP TO DBA WITH ADMIN OPTION;
BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'MANAGE_ANY',
  GRANTEE      => 'DBA',
  ADMIN_OPTION => TRUE);
END;
/
GRANT MANAGE FILE GROUP TO DBA WITH ADMIN OPTION;
GRANT MANAGE SCHEDULER TO DBA WITH ADMIN OPTION;
GRANT MANAGE TABLESPACE TO DBA WITH ADMIN OPTION;
GRANT MERGE ANY VIEW TO DBA WITH ADMIN OPTION;
GRANT ON COMMIT REFRESH TO DBA WITH ADMIN OPTION;
GRANT QUERY REWRITE TO DBA WITH ADMIN OPTION;
GRANT READ ANY FILE GROUP TO DBA WITH ADMIN OPTION;
GRANT RESTRICTED SESSION TO DBA WITH ADMIN OPTION;
GRANT RESUMABLE TO DBA WITH ADMIN OPTION;
GRANT SELECT ANY CUBE TO DBA WITH ADMIN OPTION;
GRANT SELECT ANY CUBE DIMENSION TO DBA WITH ADMIN OPTION;
GRANT SELECT ANY DICTIONARY TO DBA WITH ADMIN OPTION;
GRANT SELECT ANY MINING MODEL TO DBA WITH ADMIN OPTION;
GRANT SELECT ANY SEQUENCE TO DBA WITH ADMIN OPTION;
GRANT SELECT ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT SELECT ANY TRANSACTION TO DBA WITH ADMIN OPTION;
GRANT UNDER ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT UNDER ANY TYPE TO DBA WITH ADMIN OPTION;
GRANT UNDER ANY VIEW TO DBA WITH ADMIN OPTION;
GRANT UNLIMITED TABLESPACE TO DBA WITH ADMIN OPTION;
GRANT UPDATE ANY CUBE TO DBA WITH ADMIN OPTION;
GRANT UPDATE ANY CUBE BUILD PROCESS TO DBA WITH ADMIN OPTION;
GRANT UPDATE ANY CUBE DIMENSION TO DBA WITH ADMIN OPTION;
GRANT UPDATE ANY TABLE TO DBA WITH ADMIN OPTION;
GRANT DATAPUMP_EXP_FULL_DATABASE TO DBA;
GRANT DATAPUMP_IMP_FULL_DATABASE TO DBA;
GRANT DELETE_CATALOG_ROLE TO DBA WITH ADMIN OPTION;
GRANT EXECUTE_CATALOG_ROLE TO DBA WITH ADMIN OPTION;
GRANT EXP_FULL_DATABASE TO DBA;
GRANT GATHER_SYSTEM_STATISTICS TO DBA;
GRANT IMP_FULL_DATABASE TO DBA;
GRANT PLUSTRACE TO DBA WITH ADMIN OPTION;
GRANT SCHEDULER_ADMIN TO DBA WITH ADMIN OPTION;
GRANT SELECT_CATALOG_ROLE TO DBA WITH ADMIN OPTION;
GRANT XDBADMIN TO DBA;
GRANT XDB_SET_INVOKER TO DBA;


CREATE USER ARCH
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSTEM
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  ACCOUNT UNLOCK;
  -- 2 Roles for ARCH 
  GRANT CONNECT TO ARCH;
  GRANT DBA TO ARCH;
  ALTER USER ARCH DEFAULT ROLE NONE;
  -- 206 System Privileges for ARCH 
  GRANT ADMINISTER ANY SQL TUNING SET TO ARCH;
  GRANT ADMINISTER DATABASE TRIGGER TO ARCH;
  BEGIN
SYS.DBMS_RESOURCE_MANAGER_PRIVS.GRANT_SYSTEM_PRIVILEGE
  (GRANTEE_NAME   => 'ARCH', 
   PRIVILEGE_NAME => 'ADMINISTER_RESOURCE_MANAGER',
   ADMIN_OPTION   => FALSE);
END;
/
  GRANT ADMINISTER SQL MANAGEMENT OBJECT TO ARCH;
  GRANT ADMINISTER SQL TUNING SET TO ARCH;
  GRANT ADVISOR TO ARCH;
  GRANT ALTER ANY ASSEMBLY TO ARCH;
  GRANT ALTER ANY CLUSTER TO ARCH;
  GRANT ALTER ANY CUBE TO ARCH;
  GRANT ALTER ANY CUBE DIMENSION TO ARCH;
  GRANT ALTER ANY DIMENSION TO ARCH;
  GRANT ALTER ANY EDITION TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.ALTER_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT ALTER ANY INDEX TO ARCH;
  GRANT ALTER ANY INDEXTYPE TO ARCH;
  GRANT ALTER ANY LIBRARY TO ARCH;
  GRANT ALTER ANY MATERIALIZED VIEW TO ARCH;
  GRANT ALTER ANY MINING MODEL TO ARCH;
  GRANT ALTER ANY OPERATOR TO ARCH;
  GRANT ALTER ANY OUTLINE TO ARCH;
  GRANT ALTER ANY PROCEDURE TO ARCH;
  GRANT ALTER ANY ROLE TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.ALTER_ANY_RULE,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.ALTER_ANY_RULE_SET,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT ALTER ANY SEQUENCE TO ARCH;
  GRANT ALTER ANY SQL PROFILE TO ARCH;
  GRANT ALTER ANY TABLE TO ARCH;
  GRANT ALTER ANY TRIGGER TO ARCH;
  GRANT ALTER ANY TYPE TO ARCH;
  GRANT ALTER DATABASE TO ARCH;
  GRANT ALTER DATABASE LINK TO ARCH;
  GRANT ALTER PROFILE TO ARCH;
  GRANT ALTER PUBLIC DATABASE LINK TO ARCH;
  GRANT ALTER RESOURCE COST TO ARCH;
  GRANT ALTER ROLLBACK SEGMENT TO ARCH;
  GRANT ALTER SESSION TO ARCH;
  GRANT ALTER SYSTEM TO ARCH;
  GRANT ALTER TABLESPACE TO ARCH;
  GRANT ALTER USER TO ARCH;
  GRANT ANALYZE ANY TO ARCH;
  GRANT ANALYZE ANY DICTIONARY TO ARCH;
  GRANT AUDIT ANY TO ARCH;
  GRANT AUDIT SYSTEM TO ARCH;
  GRANT BACKUP ANY TABLE TO ARCH;
  GRANT BECOME USER TO ARCH;
  GRANT CHANGE NOTIFICATION TO ARCH;
  GRANT COMMENT ANY MINING MODEL TO ARCH;
  GRANT COMMENT ANY TABLE TO ARCH;
  GRANT CREATE ANY ASSEMBLY TO ARCH;
  GRANT CREATE ANY CLUSTER TO ARCH;
  GRANT CREATE ANY CONTEXT TO ARCH;
  GRANT CREATE ANY CUBE TO ARCH;
  GRANT CREATE ANY CUBE BUILD PROCESS TO ARCH;
  GRANT CREATE ANY CUBE DIMENSION TO ARCH;
  GRANT CREATE ANY DIMENSION TO ARCH;
  GRANT CREATE ANY DIRECTORY TO ARCH;
  GRANT CREATE ANY EDITION TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT CREATE ANY INDEX TO ARCH;
  GRANT CREATE ANY INDEXTYPE TO ARCH;
  GRANT CREATE ANY JOB TO ARCH;
  GRANT CREATE ANY LIBRARY TO ARCH;
  GRANT CREATE ANY MATERIALIZED VIEW TO ARCH;
  GRANT CREATE ANY MEASURE FOLDER TO ARCH;
  GRANT CREATE ANY MINING MODEL TO ARCH;
  GRANT CREATE ANY OPERATOR TO ARCH;
  GRANT CREATE ANY OUTLINE TO ARCH;
  GRANT CREATE ANY PROCEDURE TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_ANY_RULE,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_ANY_RULE_SET,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT CREATE ANY SEQUENCE TO ARCH;
  GRANT CREATE ANY SQL PROFILE TO ARCH;
  GRANT CREATE ANY SYNONYM TO ARCH;
  GRANT CREATE ANY TABLE TO ARCH;
  GRANT CREATE ANY TRIGGER TO ARCH;
  GRANT CREATE ANY TYPE TO ARCH;
  GRANT CREATE ANY VIEW TO ARCH;
  GRANT CREATE ASSEMBLY TO ARCH;
  GRANT CREATE CLUSTER TO ARCH;
  GRANT CREATE CUBE TO ARCH;
  GRANT CREATE CUBE BUILD PROCESS TO ARCH;
  GRANT CREATE CUBE DIMENSION TO ARCH;
  GRANT CREATE DATABASE LINK TO ARCH;
  GRANT CREATE DIMENSION TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_EVALUATION_CONTEXT_OBJ,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT CREATE EXTERNAL JOB TO ARCH;
  GRANT CREATE INDEXTYPE TO ARCH;
  GRANT CREATE JOB TO ARCH;
  GRANT CREATE LIBRARY TO ARCH;
  GRANT CREATE MATERIALIZED VIEW TO ARCH;
  GRANT CREATE MEASURE FOLDER TO ARCH;
  GRANT CREATE MINING MODEL TO ARCH;
  GRANT CREATE OPERATOR TO ARCH;
  GRANT CREATE PROCEDURE TO ARCH;
  GRANT CREATE PROFILE TO ARCH;
  GRANT CREATE PUBLIC DATABASE LINK TO ARCH;
  GRANT CREATE PUBLIC SYNONYM TO ARCH;
  GRANT CREATE ROLE TO ARCH;
  GRANT CREATE ROLLBACK SEGMENT TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_RULE_OBJ,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_RULE_SET_OBJ,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT CREATE SEQUENCE TO ARCH;
  GRANT CREATE SESSION TO ARCH;
  GRANT CREATE SYNONYM TO ARCH;
  GRANT CREATE TABLE TO ARCH;
  GRANT CREATE TABLESPACE TO ARCH;
  GRANT CREATE TRIGGER TO ARCH;
  GRANT CREATE TYPE TO ARCH;
  GRANT CREATE USER TO ARCH;
  GRANT CREATE VIEW TO ARCH;
  GRANT DEBUG ANY PROCEDURE TO ARCH;
  GRANT DEBUG CONNECT SESSION TO ARCH;
  GRANT DELETE ANY CUBE DIMENSION TO ARCH;
  GRANT DELETE ANY MEASURE FOLDER TO ARCH;
  GRANT DELETE ANY TABLE TO ARCH;
  BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'DEQUEUE_ANY',
  GRANTEE      => 'ARCH',
  ADMIN_OPTION => FALSE);
END;
/
  GRANT DROP ANY ASSEMBLY TO ARCH;
  GRANT DROP ANY CLUSTER TO ARCH;
  GRANT DROP ANY CONTEXT TO ARCH;
  GRANT DROP ANY CUBE TO ARCH;
  GRANT DROP ANY CUBE BUILD PROCESS TO ARCH;
  GRANT DROP ANY CUBE DIMENSION TO ARCH;
  GRANT DROP ANY DIMENSION TO ARCH;
  GRANT DROP ANY DIRECTORY TO ARCH;
  GRANT DROP ANY EDITION TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.DROP_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT DROP ANY INDEX TO ARCH;
  GRANT DROP ANY INDEXTYPE TO ARCH;
  GRANT DROP ANY LIBRARY TO ARCH;
  GRANT DROP ANY MATERIALIZED VIEW TO ARCH;
  GRANT DROP ANY MEASURE FOLDER TO ARCH;
  GRANT DROP ANY MINING MODEL TO ARCH;
  GRANT DROP ANY OPERATOR TO ARCH;
  GRANT DROP ANY OUTLINE TO ARCH;
  GRANT DROP ANY PROCEDURE TO ARCH;
  GRANT DROP ANY ROLE TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.DROP_ANY_RULE,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.DROP_ANY_RULE_SET,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT DROP ANY SEQUENCE TO ARCH;
  GRANT DROP ANY SQL PROFILE TO ARCH;
  GRANT DROP ANY SYNONYM TO ARCH;
  GRANT DROP ANY TABLE TO ARCH;
  GRANT DROP ANY TRIGGER TO ARCH;
  GRANT DROP ANY TYPE TO ARCH;
  GRANT DROP ANY VIEW TO ARCH;
  GRANT DROP PROFILE TO ARCH;
  GRANT DROP PUBLIC DATABASE LINK TO ARCH;
  GRANT DROP PUBLIC SYNONYM TO ARCH;
  GRANT DROP ROLLBACK SEGMENT TO ARCH;
  GRANT DROP TABLESPACE TO ARCH;
  GRANT DROP USER TO ARCH;
  BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'ENQUEUE_ANY',
  GRANTEE      => 'ARCH',
  ADMIN_OPTION => FALSE);
END;
/
  GRANT EXECUTE ANY ASSEMBLY TO ARCH;
  GRANT EXECUTE ANY CLASS TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.EXECUTE_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT EXECUTE ANY INDEXTYPE TO ARCH;
  GRANT EXECUTE ANY LIBRARY TO ARCH;
  GRANT EXECUTE ANY OPERATOR TO ARCH;
  GRANT EXECUTE ANY PROCEDURE TO ARCH;
  GRANT EXECUTE ANY PROGRAM TO ARCH;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.EXECUTE_ANY_RULE,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.EXECUTE_ANY_RULE_SET,
  GRANTEE      => 'ARCH',
  GRANT_OPTION => FALSE);
END;
/
  GRANT EXECUTE ANY TYPE TO ARCH;
  GRANT EXECUTE ASSEMBLY TO ARCH;
  GRANT EXEMPT ACCESS POLICY TO ARCH;
  GRANT EXEMPT IDENTITY POLICY TO ARCH;
  GRANT EXPORT FULL DATABASE TO ARCH;
  GRANT FLASHBACK ANY TABLE TO ARCH;
  GRANT FLASHBACK ARCHIVE ADMINISTER TO ARCH;
  GRANT FORCE ANY TRANSACTION TO ARCH;
  GRANT FORCE TRANSACTION TO ARCH;
  GRANT GLOBAL QUERY REWRITE TO ARCH;
  GRANT GRANT ANY OBJECT PRIVILEGE TO ARCH;
  GRANT GRANT ANY PRIVILEGE TO ARCH;
  GRANT GRANT ANY ROLE TO ARCH;
  GRANT IMPORT FULL DATABASE TO ARCH;
  GRANT INSERT ANY CUBE DIMENSION TO ARCH;
  GRANT INSERT ANY MEASURE FOLDER TO ARCH;
  GRANT INSERT ANY TABLE TO ARCH;
  GRANT LOCK ANY TABLE TO ARCH;
  GRANT MANAGE ANY FILE GROUP TO ARCH;
  BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'MANAGE_ANY',
  GRANTEE      => 'ARCH',
  ADMIN_OPTION => FALSE);
END;
/
  GRANT MANAGE FILE GROUP TO ARCH;
  GRANT MANAGE SCHEDULER TO ARCH;
  GRANT MANAGE TABLESPACE TO ARCH;
  GRANT MERGE ANY VIEW TO ARCH;
  GRANT ON COMMIT REFRESH TO ARCH;
  GRANT QUERY REWRITE TO ARCH;
  GRANT READ ANY FILE GROUP TO ARCH;
  GRANT RESTRICTED SESSION TO ARCH;
  GRANT RESUMABLE TO ARCH;
  GRANT SELECT ANY CUBE TO ARCH;
  GRANT SELECT ANY CUBE DIMENSION TO ARCH;
  GRANT SELECT ANY DICTIONARY TO ARCH;
  GRANT SELECT ANY MINING MODEL TO ARCH;
  GRANT SELECT ANY SEQUENCE TO ARCH;
  GRANT SELECT ANY TABLE TO ARCH;
  GRANT SELECT ANY TRANSACTION TO ARCH;
  GRANT UNDER ANY TABLE TO ARCH;
  GRANT UNDER ANY TYPE TO ARCH;
  GRANT UNDER ANY VIEW TO ARCH;
  GRANT UNLIMITED TABLESPACE TO ARCH;
  GRANT UPDATE ANY CUBE TO ARCH;
  GRANT UPDATE ANY CUBE BUILD PROCESS TO ARCH;
  GRANT UPDATE ANY CUBE DIMENSION TO ARCH;
  GRANT UPDATE ANY TABLE TO ARCH;


CREATE USER SYS
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSTEM
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  ACCOUNT UNLOCK;
  -- 32 Roles for SYS 
  GRANT ADM_PARALLEL_EXECUTE_TASK TO SYS WITH ADMIN OPTION;
  GRANT APEX_ADMINISTRATOR_ROLE TO SYS WITH ADMIN OPTION;
  GRANT AQ_ADMINISTRATOR_ROLE TO SYS WITH ADMIN OPTION;
  GRANT AQ_USER_ROLE TO SYS WITH ADMIN OPTION;
  GRANT AUTHENTICATEDUSER TO SYS WITH ADMIN OPTION;
  GRANT CONNECT TO SYS WITH ADMIN OPTION;
  GRANT CTXAPP TO SYS WITH ADMIN OPTION;
  GRANT DATAPUMP_EXP_FULL_DATABASE TO SYS WITH ADMIN OPTION;
  GRANT DATAPUMP_IMP_FULL_DATABASE TO SYS WITH ADMIN OPTION;
  GRANT DBA TO SYS WITH ADMIN OPTION;
  GRANT DBFS_ROLE TO SYS WITH ADMIN OPTION;
  GRANT DELETE_CATALOG_ROLE TO SYS WITH ADMIN OPTION;
  GRANT EXECUTE_CATALOG_ROLE TO SYS WITH ADMIN OPTION;
  GRANT EXP_FULL_DATABASE TO SYS WITH ADMIN OPTION;
  GRANT GATHER_SYSTEM_STATISTICS TO SYS WITH ADMIN OPTION;
  GRANT HS_ADMIN_EXECUTE_ROLE TO SYS WITH ADMIN OPTION;
  GRANT HS_ADMIN_ROLE TO SYS WITH ADMIN OPTION;
  GRANT HS_ADMIN_SELECT_ROLE TO SYS WITH ADMIN OPTION;
  GRANT IMP_FULL_DATABASE TO SYS WITH ADMIN OPTION;
  GRANT LOGSTDBY_ADMINISTRATOR TO SYS WITH ADMIN OPTION;
  GRANT OEM_ADVISOR TO SYS WITH ADMIN OPTION;
  GRANT OEM_MONITOR TO SYS WITH ADMIN OPTION;
  GRANT PLUSTRACE TO SYS WITH ADMIN OPTION;
  GRANT RECOVERY_CATALOG_OWNER TO SYS WITH ADMIN OPTION;
  GRANT RESOURCE TO SYS WITH ADMIN OPTION;
  GRANT SCHEDULER_ADMIN TO SYS WITH ADMIN OPTION;
  GRANT SELECT_CATALOG_ROLE TO SYS WITH ADMIN OPTION;
  GRANT XDBADMIN TO SYS WITH ADMIN OPTION;
  GRANT XDB_SET_INVOKER TO SYS WITH ADMIN OPTION;
  GRANT XDB_WEBSERVICES TO SYS WITH ADMIN OPTION;
  GRANT XDB_WEBSERVICES_OVER_HTTP TO SYS WITH ADMIN OPTION;
  GRANT XDB_WEBSERVICES_WITH_PUBLIC TO SYS WITH ADMIN OPTION;
  ALTER USER SYS DEFAULT ROLE ALL;
  -- 200 System Privileges for SYS 
  GRANT ADMINISTER ANY SQL TUNING SET TO SYS;
  GRANT ADMINISTER DATABASE TRIGGER TO SYS;
  BEGIN
SYS.DBMS_RESOURCE_MANAGER_PRIVS.GRANT_SYSTEM_PRIVILEGE
  (GRANTEE_NAME   => 'SYS', 
   PRIVILEGE_NAME => 'ADMINISTER_RESOURCE_MANAGER',
   ADMIN_OPTION   => FALSE);
END;
/
  GRANT ADMINISTER SQL MANAGEMENT OBJECT TO SYS;
  GRANT ADMINISTER SQL TUNING SET TO SYS;
  GRANT ADVISOR TO SYS;
  GRANT ALTER ANY ASSEMBLY TO SYS;
  GRANT ALTER ANY CLUSTER TO SYS;
  GRANT ALTER ANY CUBE TO SYS;
  GRANT ALTER ANY CUBE DIMENSION TO SYS;
  GRANT ALTER ANY DIMENSION TO SYS;
  GRANT ALTER ANY EDITION TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.ALTER_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT ALTER ANY INDEX TO SYS;
  GRANT ALTER ANY INDEXTYPE TO SYS;
  GRANT ALTER ANY LIBRARY TO SYS;
  GRANT ALTER ANY MATERIALIZED VIEW TO SYS;
  GRANT ALTER ANY MINING MODEL TO SYS;
  GRANT ALTER ANY OPERATOR TO SYS;
  GRANT ALTER ANY OUTLINE TO SYS;
  GRANT ALTER ANY PROCEDURE TO SYS;
  GRANT ALTER ANY ROLE TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.ALTER_ANY_RULE,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.ALTER_ANY_RULE_SET,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT ALTER ANY SEQUENCE TO SYS;
  GRANT ALTER ANY SQL PROFILE TO SYS;
  GRANT ALTER ANY TABLE TO SYS;
  GRANT ALTER ANY TRIGGER TO SYS;
  GRANT ALTER ANY TYPE TO SYS;
  GRANT ALTER DATABASE TO SYS;
  GRANT ALTER PROFILE TO SYS;
  GRANT ALTER RESOURCE COST TO SYS;
  GRANT ALTER ROLLBACK SEGMENT TO SYS;
  GRANT ALTER SESSION TO SYS;
  GRANT ALTER SYSTEM TO SYS;
  GRANT ALTER TABLESPACE TO SYS;
  GRANT ALTER USER TO SYS;
  GRANT ANALYZE ANY TO SYS;
  GRANT AUDIT ANY TO SYS;
  GRANT AUDIT SYSTEM TO SYS;
  GRANT BACKUP ANY TABLE TO SYS;
  GRANT BECOME USER TO SYS;
  GRANT CHANGE NOTIFICATION TO SYS;
  GRANT COMMENT ANY MINING MODEL TO SYS;
  GRANT COMMENT ANY TABLE TO SYS;
  GRANT CREATE ANY ASSEMBLY TO SYS;
  GRANT CREATE ANY CLUSTER TO SYS;
  GRANT CREATE ANY CONTEXT TO SYS;
  GRANT CREATE ANY CUBE TO SYS;
  GRANT CREATE ANY CUBE BUILD PROCESS TO SYS;
  GRANT CREATE ANY CUBE DIMENSION TO SYS;
  GRANT CREATE ANY DIMENSION TO SYS;
  GRANT CREATE ANY DIRECTORY TO SYS;
  GRANT CREATE ANY EDITION TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT CREATE ANY INDEX TO SYS;
  GRANT CREATE ANY INDEXTYPE TO SYS;
  GRANT CREATE ANY JOB TO SYS;
  GRANT CREATE ANY LIBRARY TO SYS;
  GRANT CREATE ANY MATERIALIZED VIEW TO SYS;
  GRANT CREATE ANY MEASURE FOLDER TO SYS;
  GRANT CREATE ANY MINING MODEL TO SYS;
  GRANT CREATE ANY OPERATOR TO SYS;
  GRANT CREATE ANY OUTLINE TO SYS;
  GRANT CREATE ANY PROCEDURE TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_ANY_RULE,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_ANY_RULE_SET,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT CREATE ANY SEQUENCE TO SYS;
  GRANT CREATE ANY SQL PROFILE TO SYS;
  GRANT CREATE ANY SYNONYM TO SYS;
  GRANT CREATE ANY TABLE TO SYS;
  GRANT CREATE ANY TRIGGER TO SYS;
  GRANT CREATE ANY TYPE TO SYS;
  GRANT CREATE ANY VIEW TO SYS;
  GRANT CREATE ASSEMBLY TO SYS;
  GRANT CREATE CLUSTER TO SYS;
  GRANT CREATE CUBE TO SYS;
  GRANT CREATE CUBE BUILD PROCESS TO SYS;
  GRANT CREATE CUBE DIMENSION TO SYS;
  GRANT CREATE DATABASE LINK TO SYS;
  GRANT CREATE DIMENSION TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_EVALUATION_CONTEXT_OBJ,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT CREATE EXTERNAL JOB TO SYS;
  GRANT CREATE INDEXTYPE TO SYS;
  GRANT CREATE JOB TO SYS;
  GRANT CREATE LIBRARY TO SYS;
  GRANT CREATE MATERIALIZED VIEW TO SYS;
  GRANT CREATE MEASURE FOLDER TO SYS;
  GRANT CREATE MINING MODEL TO SYS;
  GRANT CREATE OPERATOR TO SYS;
  GRANT CREATE PROCEDURE TO SYS;
  GRANT CREATE PROFILE TO SYS;
  GRANT CREATE PUBLIC DATABASE LINK TO SYS;
  GRANT CREATE PUBLIC SYNONYM TO SYS;
  GRANT CREATE ROLE TO SYS;
  GRANT CREATE ROLLBACK SEGMENT TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_RULE_OBJ,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.CREATE_RULE_SET_OBJ,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT CREATE SEQUENCE TO SYS;
  GRANT CREATE SESSION TO SYS;
  GRANT CREATE SYNONYM TO SYS;
  GRANT CREATE TABLE TO SYS;
  GRANT CREATE TABLESPACE TO SYS;
  GRANT CREATE TRIGGER TO SYS;
  GRANT CREATE TYPE TO SYS;
  GRANT CREATE USER TO SYS;
  GRANT CREATE VIEW TO SYS;
  GRANT DEBUG ANY PROCEDURE TO SYS;
  GRANT DEBUG CONNECT SESSION TO SYS;
  GRANT DELETE ANY CUBE DIMENSION TO SYS;
  GRANT DELETE ANY MEASURE FOLDER TO SYS;
  GRANT DELETE ANY TABLE TO SYS;
  BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'DEQUEUE_ANY',
  GRANTEE      => 'SYS',
  ADMIN_OPTION => TRUE);
END;
/
  GRANT DROP ANY ASSEMBLY TO SYS;
  GRANT DROP ANY CLUSTER TO SYS;
  GRANT DROP ANY CONTEXT TO SYS;
  GRANT DROP ANY CUBE TO SYS;
  GRANT DROP ANY CUBE BUILD PROCESS TO SYS;
  GRANT DROP ANY CUBE DIMENSION TO SYS;
  GRANT DROP ANY DIMENSION TO SYS;
  GRANT DROP ANY DIRECTORY TO SYS;
  GRANT DROP ANY EDITION TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.DROP_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT DROP ANY INDEX TO SYS;
  GRANT DROP ANY INDEXTYPE TO SYS;
  GRANT DROP ANY LIBRARY TO SYS;
  GRANT DROP ANY MATERIALIZED VIEW TO SYS;
  GRANT DROP ANY MEASURE FOLDER TO SYS;
  GRANT DROP ANY MINING MODEL TO SYS;
  GRANT DROP ANY OPERATOR TO SYS;
  GRANT DROP ANY OUTLINE TO SYS;
  GRANT DROP ANY PROCEDURE TO SYS;
  GRANT DROP ANY ROLE TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.DROP_ANY_RULE,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.DROP_ANY_RULE_SET,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT DROP ANY SEQUENCE TO SYS;
  GRANT DROP ANY SQL PROFILE TO SYS;
  GRANT DROP ANY SYNONYM TO SYS;
  GRANT DROP ANY TABLE TO SYS;
  GRANT DROP ANY TRIGGER TO SYS;
  GRANT DROP ANY TYPE TO SYS;
  GRANT DROP ANY VIEW TO SYS;
  GRANT DROP PROFILE TO SYS;
  GRANT DROP PUBLIC DATABASE LINK TO SYS;
  GRANT DROP PUBLIC SYNONYM TO SYS;
  GRANT DROP ROLLBACK SEGMENT TO SYS;
  GRANT DROP TABLESPACE TO SYS;
  GRANT DROP USER TO SYS;
  BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'ENQUEUE_ANY',
  GRANTEE      => 'SYS',
  ADMIN_OPTION => TRUE);
END;
/
  GRANT EXECUTE ANY ASSEMBLY TO SYS;
  GRANT EXECUTE ANY CLASS TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.EXECUTE_ANY_EVALUATION_CONTEXT,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT EXECUTE ANY INDEXTYPE TO SYS;
  GRANT EXECUTE ANY LIBRARY TO SYS;
  GRANT EXECUTE ANY OPERATOR TO SYS;
  GRANT EXECUTE ANY PROCEDURE TO SYS;
  GRANT EXECUTE ANY PROGRAM TO SYS;
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.EXECUTE_ANY_RULE,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  BEGIN
SYS.DBMS_RULE_ADM.GRANT_SYSTEM_PRIVILEGE(
  PRIVILEGE    => SYS.DBMS_RULE_ADM.EXECUTE_ANY_RULE_SET,
  GRANTEE      => 'SYS',
  GRANT_OPTION => TRUE);
END;
/
  GRANT EXECUTE ANY TYPE TO SYS;
  GRANT EXECUTE ASSEMBLY TO SYS;
  GRANT EXPORT FULL DATABASE TO SYS;
  GRANT FLASHBACK ANY TABLE TO SYS;
  GRANT FLASHBACK ARCHIVE ADMINISTER TO SYS;
  GRANT FORCE ANY TRANSACTION TO SYS;
  GRANT FORCE TRANSACTION TO SYS;
  GRANT GLOBAL QUERY REWRITE TO SYS;
  GRANT GRANT ANY OBJECT PRIVILEGE TO SYS;
  GRANT GRANT ANY PRIVILEGE TO SYS;
  GRANT GRANT ANY ROLE TO SYS;
  GRANT IMPORT FULL DATABASE TO SYS;
  GRANT INSERT ANY CUBE DIMENSION TO SYS;
  GRANT INSERT ANY MEASURE FOLDER TO SYS;
  GRANT INSERT ANY TABLE TO SYS;
  GRANT LOCK ANY TABLE TO SYS;
  GRANT MANAGE ANY FILE GROUP TO SYS;
  BEGIN
SYS.DBMS_AQADM.GRANT_SYSTEM_PRIVILEGE (
  PRIVILEGE    => 'MANAGE_ANY',
  GRANTEE      => 'SYS',
  ADMIN_OPTION => TRUE);
END;
/
  GRANT MANAGE FILE GROUP TO SYS;
  GRANT MANAGE SCHEDULER TO SYS;
  GRANT MANAGE TABLESPACE TO SYS;
  GRANT MERGE ANY VIEW TO SYS;
  GRANT ON COMMIT REFRESH TO SYS;
  GRANT QUERY REWRITE TO SYS;
  GRANT READ ANY FILE GROUP TO SYS;
  GRANT RESTRICTED SESSION TO SYS;
  GRANT RESUMABLE TO SYS;
  GRANT SELECT ANY CUBE TO SYS;
  GRANT SELECT ANY CUBE DIMENSION TO SYS;
  GRANT SELECT ANY MINING MODEL TO SYS;
  GRANT SELECT ANY SEQUENCE TO SYS;
  GRANT SELECT ANY TABLE TO SYS WITH ADMIN OPTION;
  GRANT SELECT ANY TRANSACTION TO SYS;
  GRANT UNDER ANY TABLE TO SYS;
  GRANT UNDER ANY TYPE TO SYS;
  GRANT UNDER ANY VIEW TO SYS;
  GRANT UNLIMITED TABLESPACE TO SYS;
  GRANT UPDATE ANY CUBE TO SYS;
  GRANT UPDATE ANY CUBE BUILD PROCESS TO SYS;
  GRANT UPDATE ANY CUBE DIMENSION TO SYS;
  GRANT UPDATE ANY TABLE TO SYS;


CREATE USER SYSTEM
  IDENTIFIED BY <password>
  DEFAULT TABLESPACE SYSTEM
  TEMPORARY TABLESPACE TEMP
  PROFILE DEFAULT
  ACCOUNT UNLOCK;
  -- 2 Roles for SYSTEM 
  GRANT AQ_ADMINISTRATOR_ROLE TO SYSTEM WITH ADMIN OPTION;
  GRANT DBA TO SYSTEM WITH ADMIN OPTION;
  ALTER USER SYSTEM DEFAULT ROLE ALL;
  -- 5 System Privileges for SYSTEM 
  GRANT CREATE MATERIALIZED VIEW TO SYSTEM;
  GRANT CREATE TABLE TO SYSTEM;
  GRANT GLOBAL QUERY REWRITE TO SYSTEM;
  GRANT SELECT ANY TABLE TO SYSTEM;
  GRANT UNLIMITED TABLESPACE TO SYSTEM WITH ADMIN OPTION;
  -- 1 Resoure Group Privilege for SYSTEM 
BEGIN
  SYS.DBMS_RESOURCE_MANAGER.clear_pending_area();
  SYS.DBMS_RESOURCE_MANAGER.create_pending_area();
  SYS.DBMS_RESOURCE_MANAGER_PRIVS.GRANT_SWITCH_CONSUMER_GROUP
    ('SYSTEM','SYS_GROUP',FALSE);
  SYS.DBMS_RESOURCE_MANAGER.submit_pending_area();
END;
/
BEGIN
  SYS.DBMS_RESOURCE_MANAGER.SET_INITIAL_CONSUMER_GROUP
    ('SYSTEM','SYS_GROUP');
END;
/


CREATE OR REPLACE TRIGGER SYS.aw_drop_trg AFTER DROP ON DATABASE
BEGIN
  aw_drop_proc(ora_dict_obj_type, ora_dict_obj_name, ora_dict_obj_owner);
END;
/
SHOW ERRORS;


CREATE OR REPLACE TRIGGER SYS.aw_ren_trg AFTER RENAME ON DATABASE
BEGIN
  aw_ren_proc(ora_dict_obj_type, ora_dict_obj_name, ora_dict_obj_owner);
END;
/
SHOW ERRORS;


CREATE OR REPLACE TRIGGER SYS.aw_trunc_trg AFTER TRUNCATE ON DATABASE
BEGIN
  aw_trunc_proc(ora_dict_obj_type, ora_dict_obj_name, ora_dict_obj_owner);
END;
/
SHOW ERRORS;


CREATE OR REPLACE TRIGGER SYS.XDB_PI_TRIG
BEFORE DROP OR TRUNCATE on DATABASE
BEGIN
  BEGIN
    IF (sys.is_vpd_enabled(sys.dictionary_obj_owner, sys.dictionary_obj_name, xdb.DBMS_XDBZ.IS_ENABLED_CONTENTS)) THEN
      xdb.XDB_PITRIG_PKG.pitrig_truncate(sys.dictionary_obj_owner, sys.dictionary_obj_name);
    ELSIF (sys.is_vpd_enabled(sys.dictionary_obj_owner, sys.dictionary_obj_name, xdb.DBMS_XDBZ.IS_ENABLED_RESMETADATA)) THEN
      xdb.XDB_PITRIG_PKG.pitrig_dropmetadata(sys.dictionary_obj_owner, sys.dictionary_obj_name);
    END IF;
  EXCEPTION
    WHEN OTHERS THEN
     null;
  END;
END;
/
SHOW ERRORS;